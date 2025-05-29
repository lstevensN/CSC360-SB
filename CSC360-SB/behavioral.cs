// Referenced https://www.geeksforgeeks.org/iterator-pattern/ while making this, thank you!

using System.Collections.Generic;

namespace CSC360_SB
{
    // Iterator Interface
    public abstract class Iterator<T>
    {
        public abstract bool HasNext();

        public abstract T Next();
    }


    // Concrete Iterator
    public class CollectionIterator<T> : Iterator<T>
    {
        // Collection to iterate through
        private Collection<T> collection;

        // Current "iteration" index
        private int index = 0;

        // Constructor
        public CollectionIterator(Collection<T> collection) { this.collection = collection; }

        // Checks if collection has another/"next" element
        public override bool HasNext() { return index < collection.Size(); }

        // Returns "next" element
        public override T Next()
        {
            if (HasNext()) return collection.Get(index++);
            else return default(T);
        }
    }


    // Aggregate Interface
    public abstract class IteratorAggregate<T>
    {
        public abstract Iterator<T> CreateIterator();
    }


    // Concrete Aggregate
    public class Collection<T> : IteratorAggregate<T>
    {
        // Internal list
        private List<T> collection = new List<T>();

        // Adds item to collection
        public void Add(T item) { collection.Add(item); }

        // Gets item for collection (used for iteration)
        public T Get(int index) { return collection[index]; }

        // Returns size of collection/internal list
        public int Size() { return collection.Count; }
        
        // Creates a new iterator based on this collection
        public override Iterator<T> CreateIterator() { return new CollectionIterator<T>(this); }
    }
}
