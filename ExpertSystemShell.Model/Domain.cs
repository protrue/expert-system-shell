using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpertSystemShell.Tools;

namespace ExpertSystemShell.Model
{
    public class Domain : IndexedNamedItem
    {
        public IndexedList<IndexedNamedItem> Values { get; }

        public Domain(string name) : base(name)
        {
            Values = new IndexedList<IndexedNamedItem>();
        }

        public Domain(string name, IEnumerable<string> values) : base(name)
        {
            Values = new IndexedList<IndexedNamedItem>();
            foreach (var value in values)
                Values.Add(new IndexedNamedItem(value));
        }

        public void Add(string value) => Values.Add(new IndexedNamedItem(value));
    }
}
