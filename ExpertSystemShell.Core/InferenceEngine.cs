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
        public Fact Deduce(List<Rule> rules, Variable goal)
        {
            var currentGoal = goal;

            foreach (var rule in rules)
            {
                
            }

            throw new NotImplementedException();
        }
    }
}
