namespace MainLab
{
  using System;
using System.Collections.Generic;

// Оголошуємо інтерфейс Printable, який містить метод Print.
interface Printable
{
    void Print();
}

// Клас Book реалізує інтерфейс Printable і представляє книгу.
class Book : Printable
{
    private string title;

    public Book(string title)
    {
        this.title = title;
    }

    public string GetTitle()
    {
        return title;
    }

    public void Print()
    {
        Console.WriteLine("Book: " + title);
    }
}

// Клас Magazine реалізує інтерфейс Printable і представляє журнал.
class Magazine : Printable
{
    private string title;

    public Magazine(string title)
    {
        this.title = title;
    }

    public string GetTitle()
    {
        return title;
    }

    public void Print()
    {
        Console.WriteLine("Magazine: " + title);
    }

    // Статичний метод, який виводить на консоль назви лише журналів.
    public static void PrintMagazines(List<Printable> printables)
    {
        foreach (Printable item in printables)
        {
            if (item is Magazine)
            {
                item.Print();
            }
        }
    }
}

// Клас Bookstore містить статичний метод для виведення лише книг.
class Bookstore
{
    public static void PrintBooks(List<Printable> printables)
    {
        foreach (Printable item in printables)
        {
            if (item is Book)
            {
                item.Print();
            }
        }
    }
}

}