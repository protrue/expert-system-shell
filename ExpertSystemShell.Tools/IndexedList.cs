using System;
using System.Collections;
using System.Collections.Generic;

namespace ExpertSystemShell.Tools
{
    [Serializable]
    public class IndexedList<T> : IEnumerable<T>, ICollection<T>, ICloneable where T : IndexedNamedItem
    {
        private readonly Dictionary<string, T> _indexes;
        private readonly List<T> _items;

        public T[] Items => _items.ToArray();

        public T this[int index]
        {
            get
            {
                return _items[index];
            }
            set
            {
                _indexes.Remove(_items[index].Index);
                _items[index] = value;
                _indexes[value.Index] = value;
            }
        }

        public T this[string index] => _indexes[index];

        public int Count => _items.Count;

        public bool IsReadOnly => false;

        private IndexedList(List<T> items, Dictionary<string, T> indexes)
        {
            _items = new List<T>(items);
            _indexes = new Dictionary<string, T>(_indexes);
        }

        public IndexedList()
        {
            _indexes = new Dictionary<string, T>();
            _items = new List<T>();
        }

        private void UpdateIndex(string oldName, string newName)
        {
            var index = oldName.GetIndex();
            var item = _indexes[index];
            _indexes.Remove(index);
            _indexes[newName.GetIndex()] = item;
        }

        public void Add(T item)
        {
            var index = item.Index;
            if(_indexes.ContainsKey(index))
                throw new ArgumentException();

            _indexes[index] = item;
            _items.Add(item);
            item.NameChanged += UpdateIndex;
        }

        public void Insert(int index, T item)
        {
            if(index < 0 || index > Count)
                throw new ArgumentOutOfRangeException(nameof(index));

            var itemIndex = item.Index;
            if(_indexes.ContainsKey(itemIndex))
                throw new ArgumentException();

            _indexes[itemIndex] = item;
            _items.Insert(index, item);
            item.NameChanged += UpdateIndex;
        }

        public bool Delete(int index) => Delete(_items[index]);

        public bool Delete(T item) => Delete(item.Index);

        public bool Delete(string index)
        {
            if(!_indexes.ContainsKey(index))
                throw new ArgumentException();

            var item = _indexes[index];
            item.NameChanged -= UpdateIndex;
            var itemRemoved = _items.Remove(item);
            var indexRemoved = _indexes.Remove(index);

            return itemRemoved && indexRemoved;
        }

        public void Swap(T first, T second)
        {
            var firstIndex = _items.IndexOf(first);
            var secondIndex = _items.IndexOf(second);
            Swap(firstIndex, secondIndex);
        }

        public void Swap(int first, int second)
        {
            var temporary = _items[first];
            _items[first] = _items[second];
            _items[second] = temporary;
        }

        public bool Contains(T item) => Contains(item.Index);

        public bool Contains(string index) => _indexes.ContainsKey(index);

        public IEnumerator<T> GetEnumerator() => _items.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        public void Clear()
        {
            _indexes.Clear();
            _items.Clear();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            _items.CopyTo(array, arrayIndex);
        }

        public bool Remove(T item)
        {
            return Delete(item);
        }

        public List<T> ToList()
        {
            return new List<T>(_items);
        }

        public object Clone()
        {
            var clone = new IndexedList<T>();

            foreach(var item in Items)
            {
                clone.Add((T)item.Clone());
            }

            return clone;
        }
    }
}
