using System;
using ExpertSystemShell.Tools;

namespace ExpertSystemShell.Model
{
    [Serializable]
    public class Fact : ICloneable
    {
        private IndexedNamedItem _value;

        public Variable Variable { get; set; }
        public IndexedNamedItem Value
        {
            get => _value;
            set
            {
                if (!Variable.Domain.Values.Contains(value))
                    throw new ArgumentException();

                _value = value;
            }
        }

        public Fact()
        {

        }

        public Fact(Variable variable, IndexedNamedItem value)
        {
            Variable = variable;
            Value = value;
        }
        
        public object Clone()
        {
            return new Fact((Variable)Variable.Clone(), (IndexedNamedItem)Value.Clone());
        }

        public override string ToString() => $"{Variable} = {Value}";
    }
}
