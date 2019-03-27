using System;

namespace ExpertSystemShell.Tools
{
    public class IndexedNamedItem
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
    }
}
