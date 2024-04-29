using LinqSample001;

/*static void Main(string[] args) 
{
    List<MyData> list = CreateList();

    //Query Expression
    IEnumerable<MyData> people = 
        from data in list
        where data.Name == "Bill"
        select data;

    //顯示結果
    foreach (MyData person in people) 
    {
        Console.WriteLine($"{person.Name} 是 {person.Age} 歲");
    }

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
}*/


/*static void Main(string[] args)
{
    List<MyData> list = CreateList();

    //Query Expression
    var people =   //var是強型別, 編譯之後沒有var, 會變成原來的型別 IEnumerable<MyData>, 宣告var只有區域變數, 而且一定要帶有指派運算子
        from data in list
        where data.Name == "Bill"
        select data;

    //顯示結果
    foreach (MyData person in people)
    {
        Console.WriteLine($"{person.Name} 是 {person.Age} 歲");
    }

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
}*/



static void Main(string[] args)
{
    List<MyData> list = CreateList();

    //Method Expression
    var people = list.Where((x) => x.Name == "Bill");
    //var people = list.Where((x) => x.Name == "Bill").Select((x)=> $"{x.Name} -- {x.Age}");
    //var people = Enumerable.Where(list, (x) => x.Name == "Bill");

    //顯示結果
    /*foreach (MyData person in people)
    {
        Console.WriteLine($"{person.Name} 是 {person.Age} 歲");
    }*/

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
