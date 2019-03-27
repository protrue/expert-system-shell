using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpertSystemShell.Model;

namespace ExpertSystemShell.Core
{
    public class KnowledgeBase
    {
        public List<Rule> Rules { get; set; }
        public List<Variable> Variables { get; set; }
        public List<Domain> Domains { get; set; }
    }
}
