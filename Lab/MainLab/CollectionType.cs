using System.Collections;

namespace MainLab
{
    
public class CollectionType<T>
{
    private List<T> items;

    public CollectionType()
    {
        items = new List<T>();
    }

    public CollectionType(IEnumerable<T> collection)
    {
        items = new List<T>(collection);
    }

    public void Add(T item)
    {
        items.Add(item);
    }

    public bool Remove(T item)
    {
        return items.Remove(item);
    }

    public int Count
    {
        get { return items.Count; }
    }

    public T this[int index]
    {
        get { return items[index]; }
        set { items[index] = value; }
    }
}
    
    public class CharacteristicsPEOM : IComparable<CharacteristicsPEOM>
    {
    public string Processor { get; set; } = "";
    public int Frequency { get; set; } = 0;
    public int RAM { get; set; } = 0;
    public string Type { get; set; } = "";

    public CharacteristicsPEOM(string processor, int frequency, int RAM, string type)
    {
        Processor = processor;
        Frequency = frequency;
        this.RAM = RAM;
        Type = type;
    }

    public int CompareTo(CharacteristicsPEOM other)
    {
        // Порівнюємо екземпляри за полем Frequency
        return Frequency.CompareTo(other.Frequency);
    }

    public override string ToString()
    => $"Processor: {Processor}, frequency: {Frequency}, RAM:{RAM}, type: {Type}";
    }

}