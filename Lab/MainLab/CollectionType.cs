using System;
using System.Collections;
using System.Collections.Generic;

public class CollectionType<T> : IEnumerable<T>
{
    private List<T> collection;

  
    public CollectionType()
    {
        collection = new List<T>();
    }

   
    public CollectionType(IEnumerable<T> initialItems)
    {
        collection = new List<T>(initialItems);
    }

    
    public int Count => collection.Count;

    
    public void Add(T item)
    {
        collection.Add(item);
    }

    
    public bool Remove(T item)
    {
        return collection.Remove(item);
    }

   
    public void Clear()
    {
        collection.Clear();
    }

    
    public T this[int index]
    {
        get
        {
            if (index < 0 || index >= collection.Count)
                throw new IndexOutOfRangeException("Index is out of range");
            return collection[index];
        }
        set
        {
            if (index < 0 || index >= collection.Count)
                throw new IndexOutOfRangeException("Index is out of range");
            collection[index] = value;
        }
    }

  
    public IEnumerator<T> GetEnumerator()
    {
        return collection.GetEnumerator();
    }

   
    IEnumerator IEnumerable.GetEnumerator()
    {
        return collection.GetEnumerator();
    }
}
