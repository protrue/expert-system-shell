using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace ExpertSystemShell.Tools
{
    public class IndexedList<T> : IEnumerable<T> where T : IndexedNamedItem
    {
        private readonly Dictionary<string, T> _indexes;
        private readonly List<T> _items;

        public T[] Items => _items.ToArray();

        public T this[int index] => _items[index];

        public T this[string index] => _indexes[index];

        public int Count => _items.Count;

        public IndexedList()
        {
            _indexes = new Dictionary<string, T>();
            _items = new List<T>();
        }

        private void UpdateIndex(string oldName, string newName)
        {
            var item = _indexes[oldName];
            _indexes.Remove(oldName.GetIndex());
            _indexes[newName.GetIndex()] = item;
        }

        public void Add(T item)
        {
            var index = item.Index;
            if (_indexes.ContainsKey(index))
                throw new ArgumentException();

            _indexes[index] = item;
            _items.Add(item);
            item.NameChanged += UpdateIndex;
        }

        public void Delete(int index) => Delete(_items[index]);

        public void Delete(T item) => Delete(item.Index);
        
        public void Delete(string index)
        {
            if (_indexes.ContainsKey(index))
                throw new ArgumentException();

            var item = _indexes[index];
            item.NameChanged -= UpdateIndex;
            _items.Remove(item);
            _indexes.Remove(index);
        }
        
        public bool Contains(T item) => Contains(item.Index);

        public bool Contains(string index) => _indexes.ContainsKey(index);
        
        public IEnumerator<T> GetEnumerator() => _items.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
