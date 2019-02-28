using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpertSystemShell.Model;

namespace ExpertSystemShell.Core
{
    public class WorkingMemory
    {
        public List<Rule> FiredRules;
        public List<Fact> ResolvedFacts;
        public Variable Goal;

        public WorkingMemory()
        {

        }
    }
}
