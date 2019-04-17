using System;

namespace ExpertSystemShell.Tools
{
    [Serializable]
    public class IndexedNamedItem : ICloneable
    {
        private string _name;

        public string Index { get; private set; }

        public string Name
        {
            get => _name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentOutOfRangeException(nameof(value));

                var oldName = _name;
                _name = value;
                NameChanged?.Invoke(oldName, value);
                Index = _name.GetIndex();
            }
        }

        public event Action<string,string> NameChanged;

        public IndexedNamedItem(string name)
        {
            Name = name;
        }

        public override string ToString() => Name;

        public virtual object Clone()
        {
            return new IndexedNamedItem(this.Name);
        }

        public override bool Equals(object other)
        {
            if (other == null)
                return false;

            if (!(other is IndexedNamedItem))
                return false;

            var otherCasted = (IndexedNamedItem) other;

            if (this.Index == otherCasted.Index)
                return true;

            return false;
        }
    }
}
