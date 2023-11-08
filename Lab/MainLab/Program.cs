CharSet set1 = new CharSet("abc");
CharSet set2 = new CharSet("bcd");
CharSet unionSet = set1 + set2; // Об'єднання множин
bool isSubset = set1 <= set2;  // Порівняння множин



Console.WriteLine("mnojina 1");
foreach(var item in set1.elements){
    Console.WriteLine(item);
}


Console.WriteLine("mnojina 2");
foreach(var item in set2.elements){
    Console.WriteLine(item);
}


Console.WriteLine("obednana mnojina");
foreach(var item in unionSet.elements){
    Console.WriteLine(item);
}

if(isSubset)
    Console.WriteLine("mnojina 2 bilsha za 1");
else
    Console.WriteLine("mnojina 1 bilsha za 2");
