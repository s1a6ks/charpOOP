using MainLab;

class Program
{
    static void Main()
    {
        // Завдання 1

        CollectionType<int> intCollection = new CollectionType<int>();
        intCollection.Add(1);
        intCollection.Add(2);
        intCollection.Add(3);

        Console.WriteLine("Elements in collection:");
        foreach (var item in intCollection)
        {
            Console.WriteLine(item);
        }

        // Завдання 2

        List<CharacteristicsPEOM> collection = new()
        {
            new CharacteristicsPEOM("Intel", 3000, 8, "Desktop"),
            new CharacteristicsPEOM("AMD", 2500, 16, "Laptop"),
            new CharacteristicsPEOM("ARM", 2000, 4, "Mobile")
        };

        // Сортування за частотою (Frequency)
        collection.Sort();

        // LINQ-запит для вибору елементів з RAM більше 8
        var result = from item in collection
                     where item.RAM > 8
                     select item;

        // Виведення результатів
        Console.WriteLine("Сортована колекція:");
        foreach (var item in collection)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("\nЕлементи з RAM більше 8:");
        foreach (var item in result)
        {
            Console.WriteLine(item);
        }

        // Завдання 3

        // Складний LINQ-запит 1: Знаходження середньої частоти для об'єктів з RAM більше 8
        double averageFrequency = collection
            .Where(item => item.RAM > 8)
            .Select(item => item.Frequency)
            .Average();
        Console.WriteLine($"Середня частота для об'єктів з RAM більше 8: {averageFrequency}");

        //  LINQ-запит 2: Вибір та сортування об'єктів за типом, а потім взяття перших двох
        var selectedAndSorted = collection
            .OrderBy(item => item.Type)
            .Take(2);
        Console.WriteLine("Перші два об'єкти, відсортовані за типом:");
        foreach (var item in selectedAndSorted)
        {
            Console.WriteLine(item);
        }

        //  LINQ-запит 3: Визначення, чи є хоча б один об'єкт з частотою більше 2500
        bool anyWithFrequencyOver2500 = collection.Any(item => item.Frequency > 2500);
        Console.WriteLine($"Хоча б один об'єкт з частотою більше 2500? {anyWithFrequencyOver2500}");

        //  LINQ-запит 4: Групування об'єктів за типом та підрахунок кількості об'єктів у кожній групі
        var groupedByType = collection
            .GroupBy(item => item.Type)
            .Select(group => new
            {
                Type = group.Key,
                Count = group.Count()
            });
        Console.WriteLine("Групування об'єктів за типом та підрахунок кількості у кожній групі:");
        foreach (var group in groupedByType)
        {
            Console.WriteLine($"{group.Type}: {group.Count} об'єктів");
        }

        //  LINQ-запит 5: Знаходження об'єкта з максимальною частотою та виведення інформації про нього
        var maxFrequencyObject = collection
            .OrderByDescending(item => item.Frequency)
            .First();
        Console.WriteLine("Об'єкт з максимальною частотою:");
        Console.WriteLine(maxFrequencyObject);

        // Завдання 4

        // Створення екземпляру CollectionManager для рядків
        CollectionManager<string> stringCollectionManager = new CollectionManager<string>();

        // Додавання елементів
        stringCollectionManager.AddElements(1, new List<string> { "abc", "def", "ghi" });
        stringCollectionManager.AddElements(2, new List<string> { "jkl", "mno", "pqr" });

        // Виведення колекції
        stringCollectionManager.PrintCollection();

        // Пошук та виведення
        string searchValue = "abc";
        stringCollectionManager.SearchAndPrint(searchValue);

        // Підрахунок та виведення
        int lengthToCount = 4;
        stringCollectionManager.CountAndPrintByLength(lengthToCount);

        // Сортування та виведення
        bool ascending = true;
        stringCollectionManager.SortAndPrint(ascending);
    }
}
