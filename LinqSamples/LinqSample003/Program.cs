using LinqSample003;
using System;
using System.Linq;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;


static void Main(string[] args) 
{
    /*var list = CreateList();
    //person1 是單個物件, 也就是 MyData person1
    var person1 = list.FirstOrDefault((x) => x.Age < 37);
    Console.WriteLine($"小於 37 歲的人第一個被找到的是 : {person1.Name}");

    //找不到就會跳出例外
    var person2 = list.First((x) => x.Age < 30);
    Console.WriteLine($"小於 30 歲的人第一個被找到的是 : {person2.Name}");

    Console.ReadLine();*/

    /*var list = CreateList();
    //person1 是單個物件, 也就是 MyData person1
    var person1 = list.LastOrDefault((x) => x.Age < 35);
    Console.WriteLine($"小於 35 歲的人最後一個被找到的是 : {person1.Name}");

    //找不到就會跳出例外
    var person2 = list.Last((x) => x.Age > 50);
    Console.WriteLine($"大於 50 歲的人最後一個被找到的是 : {person2.Name}");

    Console.ReadLine();*/

    /*var list = CreateList();
    //person1 是單個物件, 也就是 MyData person1
    var person1 = list.SingleOrDefault((x) => x.Name == "Tom");  //SingleOrDefault如果遇到兩個符合條件也會跳出例外
    Console.WriteLine($"找到唯一的 : {person1.Name} - {person1.Age}");

    //找不到唯一(有兩個Bill)就會跳出例外
    var person2 = list.Single((x) => x.Name == "Bill");
    Console.WriteLine($"找到唯一的 : {person2.Name} - {person2.Age}");

    Console.ReadLine();*/


    /*var list = CreateList();
    var person = list.FirstOrDefault((x) => x.Name == "倪御芹");
    //判斷回傳結果是否為 null
    if (person == null) 
    {
        Console.WriteLine("查無此人");
    }
    else
    {
        Console.WriteLine($"找到 : {person.Name} - {person.Age}");
    }

    Console.ReadLine();*/

    /*int index = 1;
    var list = CreateList();
    var person = list.ElementAtOrDefault(index);
    //判斷回傳結果是否為 null
    if (person == null)
    {
        Console.WriteLine("查無此人");
    }
    else
    {
        Console.WriteLine($"找到索引為 : {index} 的人是 {person.Name} - {person.Age}");
    }

    Console.ReadLine();*/


    /*var list = CreateList();
    string name = "David";
    bool result = list.Any((x) => x.Name == name);
    if (result)
    {
        Console.WriteLine($"找到了 : {name}");
    }
    else
    {
        Console.WriteLine($"找不到 : {name}");
    }

    Console.ReadLine();*/



    /*var list = CreateList();
    string name = "David";
    bool isAllBill = list.All((x) => x.Name == name);
    if(isAllBill) 
    {
        Console.WriteLine($"全都是 : {name}");
    }
    else 
    {
        Console.WriteLine($"有些人不叫 : {name}");
    }
    bool isAllOverForty = list.All((x) => x.Age >= 40);
    if(isAllOverForty) 
    {
        Console.WriteLine("大家都超過 40 歲");
    }
    else 
    {
        Console.WriteLine("有人不到 40 歲");
    }
    Console.ReadLine();*/



    /*var list = CreateList();
    //計算 list 中, 所有 Age 的總和
    int total = list.Sum((x) => x.Age);
    Console.WriteLine($"年齡的總和為 : {total}");
    //取得 list 中, Age 最小的值
    var minAge = list.Min((x) => x.Age);
    Console.WriteLine($"最小的年齡為 : {minAge}");
    //取得 list 中, Age 最大的值
    var maxAge = list.Max((x) => x.Age);
    Console.WriteLine($"最大的年齡為 : {maxAge}");
    //取得 list 中的數量
    //Count 和 Count() 是不一樣的
    //int x = list.Count();
    //int y = list.Count;
    //var s = "ABC";
    //int z = s.Length;
    int count = list.Count();
    Console.WriteLine($"list 總個數為 : {count}");
    int countOfBill = list.Count((x) => x.Name == "Bill");
    Console.WriteLine($"list 中的 Bill 總數量為 : {countOfBill}");
    //取得所有年齡的平均值
    var average = list.Average((x) => x.Age);
    Console.WriteLine($"年齡的平均值為 : {average}");
    Console.ReadLine();*/



    var list = CreateList();
    //找出名稱為 Bill 中的最小Age
    var min = list.Where((x) => x.Name == "Bill").Min((x) => x.Age);
    Console.WriteLine($"所有 Bill 中最小的年齡為 : {min}");

    //計算名稱為 Bill 的年齡總和
    var total = list.Where((x) => x.Name == "Bill").Sum((x) => x.Age);
    Console.WriteLine($"所有 Bill 的年齡總和是 : {total}");

    var average = list.Where((x) => x.Name == "Bill").Average((x) => x.Age);
    Console.WriteLine($"所有 Bill 的年齡平均是 : {average}");

    Console.ReadLine();
}
static List<MyData> CreateList()
{
    return new List<MyData>()
    {
        new MyData{Name = "Bill", Age = 47 },
        new MyData{Name = "John", Age = 37 },
        new MyData{Name = "Tom", Age = 48 },
        new MyData{Name = "David", Age = 36 },
        new MyData{Name = "Bill", Age = 35 },
    };
}
