using System.Collections.Generic;
using System.Linq;
using ExpertSystemShell.Model;

//using System.Data.Entity.Infrastructure;


namespace ExpertSystemShell.Core
{
    public class WorkingMemory
    {
        public Variable Goal { get; set; }
        public Fact Result { get; set; }
        public List<Rule> TriggeredRules { get; set; }
        public List<Rule> FiredRules { get; set; }
        public List<Fact> ResolvedFacts { get; set; }

        public Stack<InferenceContext> InferenceStack { get; set; }

        public List<InferenceEvent> InferenceHistory { get; set; }

        //public List<InferenceEvent> InferenceHistory { get; set; }

        public WorkingMemory()
        {
            TriggeredRules = new List<Rule>();
            FiredRules = new List<Rule>();
            ResolvedFacts = new List<Fact>();
            InferenceStack = new Stack<InferenceContext>();
            InferenceHistory = new List<InferenceEvent>();
        }

        public void Log(Variable goal) =>
            InferenceHistory.Add(new InferenceEvent() { Goal = goal });

        public void Log(Fact fact, bool isRequested = false) =>
            InferenceHistory.Add(new InferenceEvent() { Fact = fact, IsFactRequested = isRequested });

        public void Log(IEnumerable<Fact> facts) =>
            InferenceHistory.AddRange(
                facts.Select(f => new InferenceEvent() { Fact = f, IsFactRequested = false }));

        public void Log(Rule rule, bool isFired = false) =>
            InferenceHistory.Add(new InferenceEvent() { Rule = rule, IsRuleFired = isFired });

        public void Log(string text) =>
            InferenceHistory.Add(new InferenceEvent() { Text = text });
    }
}
