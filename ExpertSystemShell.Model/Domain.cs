using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpertSystemShell.Tools;

namespace ExpertSystemShell.Model
{
    [Serializable]
    public class Domain : IndexedNamedItem, ICloneable
    {
        public IndexedList<IndexedNamedItem> Values { get; set; }

        public Domain(string name, IndexedList<IndexedNamedItem> values = null) : base(name)
        {
            if (values == null)
                Values = new IndexedList<IndexedNamedItem>();
            else
                Values = values;
        }

        public Domain(string name, IEnumerable<string> values) : base(name)
        {
            Values = new IndexedList<IndexedNamedItem>();
            if (values != null)
                foreach (var value in values)
                    Values.Add(new IndexedNamedItem(value));
        }

        public void Add(string value) => Values.Add(new IndexedNamedItem(value));

        public override object Clone()
        {
            return new Domain(Name, (IndexedList<IndexedNamedItem>)Values.Clone());
        }
    }
}
