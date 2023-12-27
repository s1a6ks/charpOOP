using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



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

    public override string ToString() =>
        $"Processor: {Processor}, frequency: {Frequency}, RAM: {RAM}, type: {Type}";

    // Реалізація методу CompareTo для IComparable<T>
    public int CompareTo(CharacteristicsPEOM other)
    {
        // Приклад сортування за частотою (Frequency)
        if (ReferenceEquals(this, other)) return 0;
        if (ReferenceEquals(null, other)) return 1;

        return Frequency.CompareTo(other.Frequency);
    }
}
