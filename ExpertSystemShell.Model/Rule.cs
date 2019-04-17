using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpertSystemShell.Tools;

namespace ExpertSystemShell.Model
{
    [Serializable]
    public class Rule : IndexedNamedItem, ICloneable
    {
        public string Reason { get; set; }
        public List<Fact> Premise { get; set; }
        public List<Fact> Conclusion { get; set; }

        public Rule(string name, IEnumerable<Fact> premise = null, IEnumerable<Fact> conclusion = null, string reason = null) : base(name)
        {
            if (premise != null)
                Premise = new List<Fact>(premise);
            else
                Premise = new List<Fact>();

            if (conclusion != null)
                Conclusion = new List<Fact>(conclusion);
            else
                Conclusion = new List<Fact>();

            Reason = reason;
        }

        public override object Clone()
        {
            return new Rule((string)Name.Clone(), new List<Fact>(Premise), new List<Fact>(Conclusion), (string)Reason?.Clone());
        }
    }
}
