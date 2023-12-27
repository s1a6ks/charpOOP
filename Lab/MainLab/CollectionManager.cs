using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MainLab
{
    public class CollectionManager<T>
{
    private Dictionary<int, List<T>> collection;

    public CollectionManager()
    {
        collection = new Dictionary<int, List<T>>();
    }

    public void AddElements(int key, List<T> values)
    {
        collection.Add(key, values);
    }

    public void PrintCollection()
    {
        foreach (var entry in collection)
        {
            Console.WriteLine($"Key: {entry.Key}, Values: {string.Join(", ", entry.Value)}");
        }
        Console.WriteLine();
    }

    public void SearchAndPrint(T searchValue)
    {
        var result = collection
            .Where(entry => entry.Value.Contains(searchValue))
            .ToList();

        Console.WriteLine($"Values that contain '{searchValue}':");
        foreach (var entry in result)
        {
            Console.WriteLine($"Key: {entry.Key}, Values: {string.Join(", ", entry.Value)}");
        }
        Console.WriteLine();
    }

    public void CountAndPrintByLength(int length)
    {
        var result = collection
            .Select(entry => new
            {
                Key = entry.Key,
                Count = entry.Value.Count(item => item.ToString().Length == length)
            })
            .ToList();

        Console.WriteLine($"Number of items with length {length} in each collection:");
        foreach (var entry in result)
        {
            Console.WriteLine($"Key: {entry.Key}, Count: {entry.Count}");
        }
        Console.WriteLine();
    }

    public void SortAndPrint(bool ascending)
    {
        var sortedCollection = ascending
            ? collection.OrderBy(entry => entry.Key)
            : collection.OrderByDescending(entry => entry.Key);

        Console.WriteLine($"Sorted collection {(ascending ? "in ascending" : "in descending")} order:");
        foreach (var entry in sortedCollection)
        {
            Console.WriteLine($"Key: {entry.Key}, Values: {string.Join(", ", entry.Value)}");
        }
        Console.WriteLine();
    }
}
}