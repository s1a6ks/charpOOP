using System;
using System.Collections;
using System.Collections.Generic;

public class CollectionType<T> : IEnumerable<T>
{
    private List<T> collection;

    // Конструктор за замовчуванням
    public CollectionType()
    {
        collection = new List<T>();
    }

    // Конструктор, який приймає початковий набір елементів
    public CollectionType(IEnumerable<T> initialItems)
    {
        collection = new List<T>(initialItems);
    }

    // Кількість елементів в колекції
    public int Count => collection.Count;

    // Додавання елемента до колекції
    public void Add(T item)
    {
        collection.Add(item);
    }

    // Видалення елемента з колекції
    public bool Remove(T item)
    {
        return collection.Remove(item);
    }

    // Очищення колекції
    public void Clear()
    {
        collection.Clear();
    }

    // Перевантажений індексатор для отримання та встановлення значень за індексом
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

    // Реалізація інтерфейсу IEnumerable<T>
    public IEnumerator<T> GetEnumerator()
    {
        return collection.GetEnumerator();
    }

    // Реалізація інтерфейсу IEnumerable
    IEnumerator IEnumerable.GetEnumerator()
    {
        return collection.GetEnumerator();
    }
}
