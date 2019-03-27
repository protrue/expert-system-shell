using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpertSystemShell.Model;
using System;
using System.Data.Entity;
//using System.Data.Entity.Infrastructure;


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
