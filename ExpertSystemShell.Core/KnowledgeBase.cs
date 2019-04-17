using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpertSystemShell.Model;
using ExpertSystemShell.Tools;

namespace ExpertSystemShell.Core
{
    [Serializable]
    public class KnowledgeBase
    {
        public string Name { get; set; }

        public IndexedList<Rule> Rules { get; set; }
        public IndexedList<Variable> Variables { get; set; }
        public IndexedList<Domain> Domains { get; set; }

        public KnowledgeBase()
        {
            Domains = new IndexedList<Domain>();
            Variables = new IndexedList<Variable>();
            Rules = new IndexedList<Rule>();
        }
    }
}
