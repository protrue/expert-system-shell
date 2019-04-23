using ExpertSystemShell.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertSystemShell.Core
{
    public class InferenceEngineFrame
    {
        public Variable Goal { get; set; }

        public List<Rule> RulesToDeduceGoal { get; set; }
    }
}
