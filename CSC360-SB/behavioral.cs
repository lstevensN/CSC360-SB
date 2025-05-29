using System;
using System.Collections;
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
        private Collection<T> collection;

        private int index = 0;


        public CollectionIterator(Collection<T> collection) { this.collection = collection; }

        public override bool HasNext() { return index < collection.Size(); }

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
        private List<T> collection = new List<T>();


        public void Add(T item) { collection.Add(item); }

        public T Get(int index) { return collection[index]; }

        public int Size() { return collection.Count; }
        
        public override Iterator<T> CreateIterator() { return new CollectionIterator<T>(this); }
    }
}
