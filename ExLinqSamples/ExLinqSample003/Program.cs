using ExLinqSample003;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

/*static void Main(string[] args) 
{
    /*var list1 = new List<int> { 1, 2, 3, 4, 5, 6};
    var list2 = new List<int> { 1, 3, 4, 7, 8, 9 };
    var union = list1.Union(list2);
    Console.WriteLine("聯集結果為 : ");
    foreach (var item in union) 
    {  
        Console.WriteLine(item); 
    }

    var intersect = list1.Intersect(list2);
    Console.WriteLine("交集結果為 : ");
    foreach (var item in intersect)
    {
        Console.WriteLine(item);
    }

    Console.ReadLine();*/


/*var list1 = new List<int> { 1, 2, 3, 4, 5, 6 };
var list2 = new List<int> { 1, 3, 4, 7, 8, 9 };
var aEXb = list1.Except(list2);
Console.WriteLine("A 差集 B 的結果為 : ");
foreach (var item in aEXb)
{
    Console.WriteLine(item);
}

var bEXa = list2.Except(list1);
Console.WriteLine("B 差集 A 的結果為 : ");
foreach (var item in bEXa)
{
    Console.WriteLine(item);
}

Console.ReadLine();*/


/* var list = new List<string> { "台北", "台北", "洛杉磯", "紐約", "紐約", "台北"};
 var result = list.Distinct();
 foreach (var item in result)
 {
     Console.WriteLine(item);
 }

 Console.ReadLine();   
}*/



/*static void Main(string[] args) 
{
    var list = new List<string> { "A", "B", "C", "D", "E", "F", "F" };
    var resultOfSkip = list.Skip(3);
    Console.WriteLine("Skip(3) 的結果是 : ");
    Display(resultOfSkip);

    var resultOfSkipTake = list.Skip(2).Take(2);
    Console.WriteLine("Skip(2).Take(2) 的結果是 : ");
    Display(resultOfSkipTake);

    Console.ReadLine();
}

static void Display(IEnumerable<string> source) 
{
    foreach (var item in source)
    {
        Console.WriteLine(item);
    }
}*/




static void Main(string[] args) 
{
    var list = CreateList();
    var result1 = list.Where((x) => x.Age > 40).ToList();
    var result2 = list.Where((x) => x.Age > 40).ToArray();
    //使用 Name 當群組分類的索引鍵, 而值資料仍然是 MyData
    var result3 = list.Where((x) => x.Age > 40).ToDictionary((x) => x.Name);
    foreach (var item in result3)
    {
        Console.WriteLine(item.Key);
        Console.WriteLine($"{item.Value.Name} -- {item.Value.Age}");
    }
    Console.WriteLine("------------");
    //使用 Name 當群組分類的索引鍵, 而值資料仍然是 MyData
    var result4 = list.ToDictionary((x) => x.Name, (y) => y.Age);
    foreach (var item in result4)
    {
        Console.WriteLine(item.Key);
        Console.WriteLine(item.Value);
    }
}
static List<MyData> CreateList()
{
    return new List<MyData>()
    {
        new MyData{Name = "Bill", Age = 47 },
        new MyData{Name = "John", Age = 37 },
        new MyData{Name = "Tom", Age = 48 },
        new MyData{Name = "David", Age = 36 },
    };

    Console.ReadLine();
}