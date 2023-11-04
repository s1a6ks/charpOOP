using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MainLab
{
    // Оголошуємо інтерфейс "Чоловічий Одяг" з методом "одягти Чоловіка".
    interface IMensClothing
    {
        void DressMan();
    }

    // Оголошуємо інтерфейс "Жіночий Одяг" з методом "одягти Жінку".
    interface IWomensClothing
    {
        void DressWoman();
    }

    // Абстрактний клас Одяг, що містить загальні характеристики одягу.
    abstract class Clothing
    {
        public string Size { get; set; }
        public decimal Price { get; set; }
        public string Color { get; set; }

        public Clothing(string size, decimal price, string color)
        {
            Size = size;
            Price = price;
            Color = color;
        }
    }

    // Клас Футболка, який реалізує інтерфейси "Чоловічий Одяг" та "Жіночий Одяг".
    class TShirt : Clothing, IMensClothing, IWomensClothing
    {
        public TShirt(string size, decimal price, string color) : base(size, price, color) { }

        public void DressMan()
        {
            Console.WriteLine($"Men's T-Shirt: Size {Size}, Color {Color}, Price ${Price}");
        }

        public void DressWoman()
        {
            Console.WriteLine($"Women's T-Shirt: Size {Size}, Color {Color}, Price ${Price}");
        }
    }

    // Клас Штани, який реалізує інтерфейси "Чоловічий Одяг" та "Жіночий Одяг".
    class Pants : Clothing, IMensClothing, IWomensClothing
    {
        public Pants(string size, decimal price, string color) : base(size, price, color) { }

        public void DressMan()
        {
            Console.WriteLine($"Men's Pants: Size {Size}, Color {Color}, Price ${Price}");
        }

        public void DressWoman()
        {
            Console.WriteLine($"Women's Pants: Size {Size}, Color {Color}, Price ${Price}");
        }
    }

    // Клас Спідниця, який реалізує інтерфейс "Жіночий Одяг".
    class Skirt : Clothing, IWomensClothing
    {
        public Skirt(string size, decimal price, string color) : base(size, price, color) { }

        public void DressWoman()
        {
            Console.WriteLine($"Women's Skirt: Size {Size}, Color {Color}, Price ${Price}");
        }
    }

    // Клас Краватка, який реалізує інтерфейс "Чоловічий Одяг".
    class Tie : Clothing, IMensClothing
    {
        public Tie(string size, decimal price, string color) : base(size, price, color) { }

        public void DressMan()
        {
            Console.WriteLine($"Men's Tie: Size {Size}, Color {Color}, Price ${Price}");
        }
    }

    // Клас Shop, який містить масив із розмірами одягу та має метод getDescription.
    class Shop
    {
        public List<string> ClothingSizes { get; } = new List<string> { "XXS", "XS", "S", "M", "L" };

        public int EuroSize { get; set; }

        public Shop(int euroSize)
        {
            EuroSize = euroSize;
        }

        public virtual string GetDescription()
        {
            return "Дорослий розмір";
        }

        public string GetSizeByEuroSize()
        {
            if (EuroSize >= 32 && EuroSize <= 40)
            {
                return ClothingSizes[EuroSize - 32];
            }
            return "Невідомий розмір";
        }
    }

    // Клас-спадкоємець від Shop, що перевизначає метод getDescription для XXS.
    class ShopWithChildSize : Shop
    {
        public ShopWithChildSize(int euroSize) : base(euroSize) { }

        public override string GetDescription()
        {
            if (GetSizeByEuroSize() == "XXS")
            {
                return "Дитячий розмір";
            }
            return "Дорослий розмір";
        }
    }

    // Клас Ательє, що містить методи одягнути Жінку та одягнути Чоловіка.
    class Atelier
    {
        public static void DressWoman(List<IWomensClothing> clothes)
        {
            Console.WriteLine("Одягаємо Жінку:");
            foreach (IWomensClothing item in clothes)
            {
                item.DressWoman();
            }
        }

        public static void DressMan(List<IMensClothing> clothes)
        {
            Console.WriteLine("Одягаємо Чоловіка:");
            foreach (IMensClothing item in clothes)
            {
                item.DressMan();
            }
        }
    }

}