using MainLab;

class Program
{
    static void Main()
    {
        // Створюємо об'єкт планети
        Planet earth = new Planet("Земля");

        // Створюємо континенти
        Сontinent europe = new Сontinent("Європа");
        Сontinent asia = new Сontinent("Азія");
        Сontinent africa = new Сontinent("Африка");

        // Додаємо континенти до планети
        earth.AddSomeObject(europe, earth.Continents);
        earth.AddSomeObject(asia, earth.Continents);
        earth.AddSomeObject(africa, earth.Continents);

        // Створюємо океани
        Ocean atlantic = new Ocean("Атлантичний океан");
        Ocean pacific = new Ocean("Тихий океан");

        // Додаємо океани до планети
        earth.AddSomeObject(atlantic, earth.Oceans);
        earth.AddSomeObject(pacific, earth.Oceans);

        // Створюємо острови
        Island hawaii = new Island("Гаваї");
        Island madagascar = new Island("Мадагаскар");

        // Додаємо острови до планети
        earth.AddSomeObject(hawaii, earth.Islands);
        earth.AddSomeObject(madagascar, earth.Islands);

        // Виводимо інформацію про планету
        Console.WriteLine(earth);

        // Виводимо кількість об'єктів на планеті
        Console.WriteLine($"Загальна кількість континентів: {Сontinent.count}");
        Console.WriteLine($"Загальна кількість океанів: {Ocean.count}");
        Console.WriteLine($"Загальна кількість островів: {Island.count}");

        Console.WriteLine($"Hash code {earth.GetHashCode()}");
    }
}



