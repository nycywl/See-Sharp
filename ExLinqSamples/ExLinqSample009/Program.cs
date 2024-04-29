﻿using ExLinqSample009;



static void Main(string[] args)
{
    var list = CreateList();
    var result =
        from o in list
        group o by o.City into gp
        select gp;
    foreach (var item in result)
    {
        Console.WriteLine($"住在 : {item.Key}");
        foreach (var p in item)
        {
            Console.WriteLine(p.Name);
        }
        Console.WriteLine("----------");
    }

    Console.ReadLine();
}
static List<MyData> CreateList()
{
    return new List<MyData>()
    {
        new MyData{Name = "Bill", City = "台北" },
        new MyData{Name = "John", City = "台北" },
        new MyData{Name = "Tom", City = "高雄" },
        new MyData{Name = "David", City = "台南" },
        new MyData{Name = "Jeff", City = "台南" },
    };
}
