using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;

namespace More.Net.Collections.Generic
{
    /// <summary>
    /// Represents an observable collection with bulk adding and removing operations.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class BulkObservableCollection<T> : ObservableCollection<T>, IBulkCollection<T>
    {
        /// <summary>
        /// Creats an empty observable collection that supports bulk operations.
        /// </summary>
        public BulkObservableCollection()
            : base()
        {

        }

        /// <summary>
        /// Creats a new observable collection that contains elements copied from the specified
        /// collection.
        /// </summary>
        /// <param name="collection"></param>
        public BulkObservableCollection(IEnumerable<T> collection)
            : base(collection)
        {

        }

        /// <summary>
        /// Creats a new observable collection that contains elements copied from the specified
        /// list.
        /// </summary>
        /// <param name="list"></param>
        public BulkObservableCollection(List<T> list)
            : base(list)
        {

        }

        /// <summary>
        /// Adds a range of values to the collection.
        /// </summary>
        /// <param name="items"></param>
        public void AddRange(IEnumerable<T> items)
        {
            if (items.Any())
            {
                Int32 startIndex = Count;
                foreach (T item in items)
                    Items.Add(item);
                OnPropertyChanged(new PropertyChangedEventArgs("Count"));
                OnPropertyChanged(new PropertyChangedEventArgs("Item[]"));
                OnCollectionChanged(new NotifyCollectionChangedEventArgs(
                    NotifyCollectionChangedAction.Add,
                    items.ToList(),
                    startIndex));
            }
        }

        /// <summary>
        /// Removes a range of values from the collection.
        /// </summary>
        /// <param name="items"></param>
        public void RemoveRange(IEnumerable<T> items)
        {
            if (items.Any())
            {
                Int32 startIndex = Items.IndexOf(items.FirstOrDefault());
                foreach (T item in items)
                    Items.Remove(item);
                OnPropertyChanged(new PropertyChangedEventArgs("Count"));
                OnPropertyChanged(new PropertyChangedEventArgs("Item[]"));
                OnCollectionChanged(new NotifyCollectionChangedEventArgs(
                    NotifyCollectionChangedAction.Remove,
                    items.ToList(),
                    startIndex));
            }
        }

        /// <summary>
        /// Removes all items from the collection.
        /// </summary>
        protected override void ClearItems()
        {
            RemoveRange(Items.ToList());
        }
    }
}
