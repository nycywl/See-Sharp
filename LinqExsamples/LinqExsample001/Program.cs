//題目 1 : 給定一個字串列表，請找出所有字串長度大於 5 的字串，並按字串長度從大到小排序。
//要求: 使用 LINQ 語法來實現。
//輸入: `List<string>`，列表包含若干字串。
//輸出: `IEnumerable<string>`，符合條件的字串列表，按長度從大到小排序。
using System;
using System.Collections.Generic;
using System.Linq;

/*class Program
{
    static void Main()
    {
        List<string> strings = new List<string> { "Hi", "Name", "Homework", "Happy", "Weinny" };
        IEnumerable<string> result = GetStringsLongerThanFive(strings);

        // 輸出結果
        foreach (var str in result)
        {
            Console.WriteLine(str);
        }
    }

    static IEnumerable<string> GetStringsLongerThanFive(List<string> strings)
    {
        return strings
            .Where(s => s.Length > 5)
            .OrderByDescending(s => s.Length);
    }
}*/


//題目 2 : 給定一個字串列表，請找出所有以字母 "a" 開頭的字串，並將其轉換為大寫。
//要求: 使用 LINQ 語法來實現。
//輸入: `List<string>`，列表包含若干字串。
//輸出: `IEnumerable<string>`，包含所有以字母 "a" 開頭的字串，並將其轉換為大寫。

/*class Program
{
    static void Main()
    {
        List<string> strings = new List<string> { "apple", "banana", "arbutus", "orange" };
        IEnumerable<string> result = GetStringsStartingWithA(strings);

        // 輸出結果
        foreach (var str in result)
        {
            Console.WriteLine(str);
        }
    }

    static IEnumerable<string> GetStringsStartingWithA(List<string> strings)
    {
        return strings
            .Where(s => s.StartsWith("a", StringComparison.OrdinalIgnoreCase))
            .Select(s => s.ToUpper());
    }
}*/



//題目 3 : 給定一個整數列表，請計算其中每個整數的字數並返回一個新的整數列表。
//要求: 使用 LINQ 語法來實現。
//輸入: `List<int>`，列表包含若干整數。
//輸出: `IEnumerable<int>`，其中每個元素表示原列表中對應整數的字數。


/*class Program
{
    static void Main()
    {
        List<int> integers = new List<int> { 1, 23, 456, 7890 };
        IEnumerable<int> result = GetDigitCounts(integers);

        // 輸出結果
        foreach (var count in result)
        {
            Console.WriteLine(count);
        }
    }

    static IEnumerable<int> GetDigitCounts(List<int> integers)
    {
        return integers
            .Select(i => i.ToString().Length);
    }
}*/



//題目 4 : 給定一個字串列表，請找出列表中最常見的字母（忽略大小寫）。
//要求: 使用 LINQ 語法來實現。
//輸入: `List<string>`，列表包含若干字串。
//輸出: `char`，列表中最常見的字母（忽略大小寫）。

/*class Program
{
    static void Main()
    {
        List<string> strings = new List<string> { "Hi", "Name", "Homework", "YUCHIN", "Weinny" };
        char mostCommonLetter = FindMostCommonLetter(strings);

        // 輸出結果
        Console.WriteLine(mostCommonLetter);
    }

    static char FindMostCommonLetter(List<string> strings)
    {
        return strings
            .SelectMany(s => s.ToLower())
            .Where(c => char.IsLetter(c))
            .GroupBy(c => c)
            .OrderByDescending(g => g.Count())
            .First()
            .Key;
    }
}*/




//題目 5 : 給定一個字串列表，請找出所有字串中長度介於 3 到 6 的字串，並將它們以逗號分隔合併成一個字串。
//要求: 使用 LINQ 語法來實現。
//輸入: `List<string>`，列表包含若干字串。
//輸出: `string`，所有符合條件的字串以逗號分隔合併成的一個字串。


class Program
{
    static void Main()
    {
        List<string> strings = new List<string> { "Hi", "Name", "Homework", "YUCHIN", "Weinny", "apple", "banana" };
        string result = ConcatenateStringsInRange(strings);

        // 輸出結果
        Console.WriteLine(result);
    }

    static string ConcatenateStringsInRange(List<string> strings)
    {
        return strings
            .Where(s => s.Length >= 3 && s.Length <= 6)
            .Aggregate((current, next) => current + "," + next);
    }
}
