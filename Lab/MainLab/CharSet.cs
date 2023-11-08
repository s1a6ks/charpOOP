public class CharSet
{
    public List<char> elements = new List<char>();

    public CharSet() { }

    // Конструктор множини з рядку
    public CharSet(string str)
    {
        elements = str.Distinct().ToList();
    }

    // Перевантаження операції додавання елементу до множини
    public static CharSet operator +(CharSet left, char right)
    {
        CharSet result = new CharSet();
        result.elements.AddRange(left.elements);
        if (!result.elements.Contains(right))
        {
            result.elements.Add(right);
        }
        return result;
    }

    // Перевантаження операції об'єднання множин
    public static CharSet operator +(CharSet left, CharSet right)
    {
        CharSet result = new CharSet();
        result.elements.AddRange(left.elements);
        foreach (char element in right.elements)
        {
            if (!result.elements.Contains(element))
            {
                result.elements.Add(element);
            }
        }
        return result;
    }

    // Перевантаження операції порівняння множин (<=)
    public static bool operator <=(CharSet left, CharSet right)
    {
        return left.elements.All(e => right.elements.Contains(e));
    }

    public static bool operator >=(CharSet left, CharSet right)
    {
        return right.elements.All(e => left.elements.Contains(e));
    }
}