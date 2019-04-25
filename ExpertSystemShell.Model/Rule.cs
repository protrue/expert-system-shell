using System;
using System.Collections.Generic;
using ExpertSystemShell.Tools;

namespace ExpertSystemShell.Model
{
    [Serializable]
    public class Rule : IndexedNamedItem, ICloneable
    {
        public List<Fact> Premise { get; set; }
        public List<Fact> Conclusion { get; set; }

        public string Reason { get; set; }

        public Rule(string name, IEnumerable<Fact> premise = null, IEnumerable<Fact> conclusion = null, string reason = null) : base(name)
        {
            Premise = premise != null ? new List<Fact>(premise) : new List<Fact>();
            Conclusion = conclusion != null ? new List<Fact>(conclusion) : new List<Fact>();
            Reason = reason;
        }

        public override string ToString()
        {
            if (Premise.Count == 0 || Conclusion.Count == 0)
                return string.Empty;

            return $"Если {string.Join(" И ", Premise)}, то {string.Join(", ", Conclusion)}";
        }

        public override object Clone()
        {
            return new Rule((string)Name.Clone(), new List<Fact>(Premise), new List<Fact>(Conclusion), (string)Reason?.Clone());
        }
    }
}
