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

    //__________________________________________________________________________________________________________//


    int n = 5; // Задана кількість чотирикутників

            Random random = new Random();
            TQuadrangle[] quadrangles = new TQuadrangle[n];

            for (int i = 0; i < n; i++)
            {
                int shape = random.Next(3); // Вибираємо випадкову форму чотирикутника

                switch (shape)
                {
                    case 0:
                        quadrangles[i] = new Rectangle(random.Next(1, 10), random.Next(1, 10));
                        break;
                    case 1:
                        quadrangles[i] = new Square(random.Next(1, 10));
                        break;
                    case 2:
                        quadrangles[i] = new Parallelogram(random.Next(1, 10), random.Next(1, 10), random.Next(1, 10));
                        break;
                }
            }

            double sumOfRectanglesArea = 0;
            double sumOfSquaresArea = 0;
            double sumOfParallelogramsPerimeter = 0;

            foreach (TQuadrangle quad in quadrangles)
            {
                if (quad is Rectangle)
                {
                    sumOfRectanglesArea += quad.CalculateArea();
                }
                else if (quad is Square)
                {
                    sumOfSquaresArea += quad.CalculateArea();
                }
                else if (quad is Parallelogram)
                {
                    sumOfParallelogramsPerimeter += quad.CalculatePerimeter();
                }
            }

            Console.WriteLine($"Сума площ прямокутників і квадратів: {sumOfRectanglesArea + sumOfSquaresArea}");
            Console.WriteLine($"Сума периметрів паралелограмів: {sumOfParallelogramsPerimeter}");
    }
}



