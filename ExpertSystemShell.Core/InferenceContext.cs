using ExpertSystemShell.Model;
using System.Collections.Generic;

namespace ExpertSystemShell.Core
{
    public class InferenceContext
    {
        public Variable Goal { get; set; }

        public Queue<Rule> RulesToDeduce { get; set; }

        public Rule RuleToDeduce { get; set; }

        public Stack<Fact> FactsToCheck { get; set; }

        public Fact FactToCheck { get; set; }

        public Fact Result { get; set; }

        public List<Fact> Resolved { get; set; }

        public List<InferenceEvent> Events { get; set; }

        public InferenceContext()
        {
            RulesToDeduce = new Queue<Rule>();
            FactsToCheck = new Stack<Fact>();
            Resolved = new List<Fact>();
            Events = new List<InferenceEvent>();
        }
    }
}
