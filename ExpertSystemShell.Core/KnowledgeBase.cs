using System;
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

        public KnowledgeBase(string name = null)
        {
            if (name == null) name = "New knowledge base";
            Name = name;
            Domains = new IndexedList<Domain>();
            Variables = new IndexedList<Variable>();
            Rules = new IndexedList<Rule>();
        }
    }
}
