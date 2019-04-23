using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpertSystemShell.Model;

namespace ExpertSystemShell.Core
{
    public class InferenceEngine
    {
        public Fact Deduce(List<Rule> rules, Func<Variable, Task<Fact>> variableRequester, Variable goal)
        {
            var goalsStack = new Stack<Variable>();
            goalsStack.Push(goal);
            var currentGoal = goal;
            var currentRules = new Queue<Rule>();
            Rule currentRule = null;
            var factsToDeduce = new Queue<Fact>();
            Fact factToDeduce;
            var deducedFacts = new List<Fact>();
            var isRuleFired = true;

            while(goalsStack.Count != 0)
            {
                if(currentRules.Count == 0)
                {
                    currentGoal = goalsStack.Pop();

                    foreach(var rule in rules)
                    {
                        foreach(var fact in rule.Conclusion)
                        {
                            if(fact.Variable == currentGoal)
                            {
                                currentRules.Enqueue(rule);
                                break;
                            }
                        }
                    }
                }
                else
                {
                    if(factsToDeduce.Count == 0)
                    {
                        if(isRuleFired)
                        {
                            foreach(var fact in currentRule.Conclusion)
                            {
                                deducedFacts.Add(fact);
                            }
                        }

                        currentRule = currentRules.Dequeue();
                        foreach(var fact in currentRule.Premise)
                        {
                            factsToDeduce.Enqueue(fact);
                        }

                        isRuleFired = true;
                    }
                    else
                    {
                        factToDeduce = factsToDeduce.Dequeue();
                        currentGoal = factToDeduce.Variable;

                        switch(currentGoal.VariableKind)
                        {
                            case VariableKind.Requested:
                                var answerTask = variableRequester.Invoke(currentGoal);
                                answerTask.RunSynchronously();
                                deducedFacts.Add(answerTask.Result);
                                break;
                            case VariableKind.Deductible:
                                var deducedFactForCurrentGoal = deducedFacts.FirstOrDefault(f => f.Variable == currentGoal);
                                if(deducedFactForCurrentGoal != null)
                                {
                                    if(factToDeduce.Value != deducedFactForCurrentGoal.Value)
                                    {
                                        currentRule = null;
                                        factToDeduce = null;
                                        factsToDeduce.Clear();
                                        isRuleFired = false;
                                    }
                                }
                                else
                                {
                                    goalsStack.Push(factToDeduce.Variable);
                                    currentRules.Clear();
                                    factsToDeduce.Clear();
                                    isRuleFired = false;
                                }
                                break;
                            case VariableKind.DeductibleRequested:
                                break;
                            default:
                                break;
                        }
                    }
                }
            }

            return deducedFacts.FirstOrDefault(f => f.Variable == goal);
        }
    }
}
