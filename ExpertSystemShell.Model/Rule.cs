using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpertSystemShell.Tools;

namespace ExpertSystemShell.Model
{
    public class Rule : IndexedNamedItem
    {
        public string Reason { get; set; }
        public List<Fact> Premises { get; set; }
        public List<Fact> Conclusions { get; set; }

        public Rule(string name, string reason) : base(name)
        {
            Reason = reason;
        }
    }
}
