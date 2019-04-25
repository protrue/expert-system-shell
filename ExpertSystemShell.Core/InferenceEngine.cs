using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExpertSystemShell.Model;

namespace ExpertSystemShell.Core
{
    public class InferenceEngine
    {
        public KnowledgeBase KnowledgeBase { get; set; }
        public WorkingMemory WorkingMemory { get; set; }
        public Func<Variable, Task<Fact>> VariableRequester { get; set; }

        public event Action<Fact> DeduceEnded;

        public InferenceEngine(KnowledgeBase knowledgeBase, Func<Variable, Task<Fact>> variableRequester)
        {
            KnowledgeBase = knowledgeBase;
            VariableRequester = variableRequester;

            WorkingMemory = new WorkingMemory();
        }

        private Queue<Rule> GetRulesToDeduceVariable(Variable variable)
        {
            var result = new Queue<Rule>();

            foreach (var rule in KnowledgeBase.Rules)
            {
                foreach (var fact in rule.Conclusion)
                {
                    if (Equals(fact.Variable, variable))
                    {
                        result.Enqueue(rule);
                        break;
                    }
                }
            }

            return result;
        }

        private void RequestVariable(InferenceContext context)
        {
            var requestTask = VariableRequester.Invoke(context.Goal);
            var configuredTaskAwaitable = requestTask.ConfigureAwait(true);
            var configuredTaskAwaiter = configuredTaskAwaitable.GetAwaiter();
            var answerFact = configuredTaskAwaiter.GetResult();
            context.Resolved.Add(answerFact);
            context.Result = answerFact;
            WorkingMemory.ResolvedFacts.Add(answerFact);
            WorkingMemory.Log(answerFact, true);
        }

        public Fact Deduce(Variable goal)
        {
            WorkingMemory = new WorkingMemory { Goal = goal };
            var context = new InferenceContext()
            {
                Goal = goal,
                RulesToDeduce = GetRulesToDeduceVariable(goal),
            };
            WorkingMemory.InferenceStack.Push(context);
            WorkingMemory.Log(goal);

            while (WorkingMemory.InferenceStack.Count > 0)
            {
                context = WorkingMemory.InferenceStack.Pop();

                if (context.Goal.VariableKind == VariableKind.Requested)
                {
                    RequestVariable(context);
                    continue;
                }

                //if (context.RuleToDeduce == null)
                //{
                //    if (context.RulesToDeduce.Count == 0)
                //    {
                //        if (context.Result == null && WorkingMemory.InferenceStack.Count > 0)
                //        {
                //            WorkingMemory.InferenceStack.Peek().RuleToDeduce = null;
                //            WorkingMemory.InferenceStack.Peek().FactToCheck = null;
                //        }

                //        continue;
                //    }

                //    context.RuleToDeduce = context.RulesToDeduce.Dequeue();
                //    WorkingMemory.TriggeredRules.Add(context.RuleToDeduce);
                //    WorkingMemory.Log(context.RuleToDeduce);
                //}

                //if (context.FactsToCheck.Count == 0)
                //{

                //    context.FactsToCheck = new Queue<Fact>(context.RuleToDeduce.Premise);
                //}
                //context.FactToCheck = context.FactsToCheck.Dequeue();

                if (context.FactsToCheck.Count > 0)
                {
                    context.FactToCheck = context.FactsToCheck.Pop();
                }
                else
                {
                    if (context.RulesToDeduce.Count > 0)
                    {
                        context.RuleToDeduce = context.RulesToDeduce.Dequeue();
                        context.FactsToCheck = new Stack<Fact>(context.RuleToDeduce.Premise);
                        context.FactToCheck = context.FactsToCheck.Pop();

                        WorkingMemory.TriggeredRules.Add(context.RuleToDeduce);
                        WorkingMemory.Log(context.RuleToDeduce);
                    }
                    else
                    {
                        if (WorkingMemory.InferenceStack.Count > 0)
                        {
                            WorkingMemory.InferenceStack.Peek().FactsToCheck.Pop();
                        }

                        continue;
                    }
                }

                var resolvedFact =
                    WorkingMemory
                        .ResolvedFacts
                        .FirstOrDefault(f => f.Variable == context.FactToCheck.Variable);

                if (resolvedFact == null)
                {
                    var newContext = new InferenceContext()
                    {
                        Goal = context.FactToCheck.Variable,
                        RulesToDeduce = GetRulesToDeduceVariable(context.FactToCheck.Variable),
                    };

                    context.FactsToCheck.Push(context.FactToCheck);
                    WorkingMemory.InferenceStack.Push(context);
                    WorkingMemory.InferenceStack.Push(newContext);
                    WorkingMemory.Log(newContext.Goal);
                }
                else
                {
                    if (resolvedFact.Value == context.FactToCheck.Value)
                    {
                        if (context.FactsToCheck.Count == 0)
                        {
                            var resolved = context.RuleToDeduce.Conclusion;
                            context.Resolved.AddRange(resolved);
                            context.Result = resolved.FirstOrDefault(f => f.Variable == context.Goal);
                            WorkingMemory.FiredRules.Add(context.RuleToDeduce);
                            WorkingMemory.ResolvedFacts.AddRange(resolved);
                            WorkingMemory.Log(context.RuleToDeduce, true);
                            WorkingMemory.Log(resolved);
                            context.RuleToDeduce = null;
                        }
                        else
                        {
                            WorkingMemory.InferenceStack.Push(context);
                        }

                        context.FactToCheck = null;
                    }
                    else
                    {
                        context.FactToCheck = null;
                        context.RuleToDeduce = null;

                        WorkingMemory.InferenceStack.Push(context);
                    }
                }
            }

            DeduceEnded?.Invoke(context.Result);
            WorkingMemory.Result = context.Result;

            return WorkingMemory.Result;
        }
    }
}
