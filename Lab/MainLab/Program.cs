using MainLab;
using System.Linq;

// internal class Program
// {
//     private static void Main(string[] args)
//     {
//         CollectionType<CharacteristicsPEOM> pc = new CollectionType<CharacteristicsPEOM>();
//         pc.Add(new CharacteristicsPEOM("Intel Core i7", 3600, 16, "Desktop"));
//         pc.Add(new CharacteristicsPEOM("AMD Ryzen 5", 3200, 8, "Laptop"));
//         pc.Add(new CharacteristicsPEOM("Intel Core i9", 4500, 32, "Workstation"));


//         pc = new CollectionType<CharacteristicsPEOM>(pc.OrderBy(p => p));

//         // LINQ-запит
//         var result = from person in pc
//                      where person.Age > 30
//                      select person.Name;

//         foreach (var name in result)
//         {
//             Console.WriteLine(name);
//         }

//         var query1 = pc.Where(p => p.Age > 25)
//             .OrderByDescending(p => p.Age)
//             .Select(p => p.Name)
//             .Take(2);

//         var query2 = pc
//             .GroupBy(p => p.Age / 10)
//             .Select(group => new { AgeGroup = group.Key, Count = group.Count() });

//         var query3 = pc
//             .Join(pc, p1 => p1.Name, p2 => p2.Name, (p1, p2) => new { p1.Name, AgeDiff = p1.Age - p2.Age })
//             .Where(p => p.AgeDiff > 5);

//         var query4 = pc
//             .TakeWhile(p => p.Age < 35)
//             .OrderBy(p => p.Age)
//             .Skip(1);

//         var query5 = pc
//             .SelectMany(p => p.Processor.Split(''))
//             .Distinct();

//         List<string> stringList = new List<string>();
//         stringList.Add("apple");
//         stringList.Add("banana");
//         stringList.Add("cherry");

//         Console.WriteLine("Зміст колекції:");
//         foreach (string item in stringList)
//         {
//             Console.WriteLine(item);
//         }

//         string searchValue = "banana";
//         bool containsSearchValue = stringList.Contains(searchValue);
//         int countOfLength3 = stringList.Count(s => s.Length == 3);

//         stringList.Sort(); // сортування у зростаючому порядку
//         stringList.Reverse(); // сортування у спадаючому порядку
//     }
// }