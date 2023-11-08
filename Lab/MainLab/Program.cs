using MainLab;

public class Program
{
    public static void Main()
    {
        //task 1
        System.Console.WriteLine("\nTask 1");
        List<IShape> shapes = new List<IShape>
        {
            new Circle { Radius = 5.0 },
            new Circle { Radius = 3.0 },
            new Circle { Radius = 7.5 },
            new ColoredCircle { Radius = 4.0, Color = "Red" },
            new ColoredCircle { Radius = 6.0, Color = "Blue" },
            new ColoredCircle { Radius = 8.0, Color = "Green" }
        };

        PrintShapes.ProcessShapes(shapes);
        System.Console.WriteLine("\nTask 2");
        //task 2

        List<Printable> printableItems = new List<Printable>
        {
            new Book("Book 1"),
            new Magazine("Magazine 1"),
            new Book("Book 2"),
            new Magazine("Magazine 2")
        };

        Console.WriteLine("Printing all items:");
        foreach (Printable item in printableItems)
        {
            item.Print();
        }

        Console.WriteLine("\nPrinting only magazines:");
        Magazine.PrintMagazines(printableItems);

        Console.WriteLine("\nPrinting only books:");
        Bookstore.PrintBooks(printableItems);

        //task 3
        System.Console.WriteLine("\nTask 3");

        // Створюємо список об'єктів одягу різних типів.
        List<Clothing> clothes = new List<Clothing>
        {
            new TShirt("M", 25.99M, "Red"),
            new TShirt("S", 19.99M, "Blue"),
            new Pants("L", 49.99M, "Black"),
            new Skirt("XS", 39.99M, "Green"),
            new Tie("L", 29.99M, "Navy")
        };

        // Виводимо інформацію про всі види одягу.
        Console.WriteLine("Інформація про одяг:");
        foreach (Clothing item in clothes)
        {
            Console.WriteLine($"Одяг: {item.GetType().Name}, Розмір: {item.Size}, Ціна: ${item.Price}, Колір: {item.Color}");
        }

        // Створюємо магазин з розміром XXS.
        ShopWithChildSize shop = new ShopWithChildSize(32);

        // Виводимо опис розміру з магазину.
        Console.WriteLine($"Опис розміру з магазину: {shop.GetDescription()}");

        // Використовуємо ательє для одягу Жінку та Чоловіка.
        Console.WriteLine("\nВиведення одягу Жінки:");
        Atelier.DressWoman(clothes.OfType<IWomensClothing>().ToList());

        Console.WriteLine("\nВиведення одягу Чоловіка:");
        Atelier.DressMan(clothes.OfType<IMensClothing>().ToList());
 
    }    
    
}
