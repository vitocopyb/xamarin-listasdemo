using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ListasDemoApp.Helpers
{
    public class Grouping<K, T> : ObservableCollection<T>
    {
        public K Key { get; }

        public Grouping(K key, IEnumerable<T> items)
        {
            Key = key;
            foreach (T item in items)
            {
                Items.Add(item);
            }
        }
    }
}
