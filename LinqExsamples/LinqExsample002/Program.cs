//題目 1: 給定一個整數列表，請計算列表中所有元素的連續子序列，並找出總和最大的連續子序列，返回這個子序列。
//要求: 使用 LINQ 語法來實現。
//輸入: List<int>，列表包含若干整數。
//輸出: IEnumerable<int>，最大總和的連續子序列。

using System;
using System.Collections.Generic;
using System.Linq;

/*class Program
{
    static void Main()
    {
        List<int> integers = new List<int> { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
        var result = FindMaxSumSubarray(integers);

        Console.WriteLine($"最大總和的連續子序列: {string.Join(", ", result)}");
    }

    static IEnumerable<int> FindMaxSumSubarray(List<int> integers)
    {
        var maxSum = int.MinValue;
        var currentSum = 0;
        int startIndex = 0, maxStart = 0, maxEnd = 0;

        for (int i = 0; i < integers.Count; i++)
        {
            currentSum += integers[i];
            if (currentSum > maxSum)
            {
                maxSum = currentSum;
                maxStart = startIndex;
                maxEnd = i;
            }

            if (currentSum < 0)
            {
                currentSum = 0;
                startIndex = i + 1;
            }
        }

        return integers.Skip(maxStart).Take(maxEnd - maxStart + 1);
    }
}*/




//題目 2 : 給定一個整數列表，請計算出該列表中所有可能的數字對 (a, b)，並返回所有對 (a, b) 的和。
//要求: 使用 LINQ 語法來實現。
//輸入: List<int>，列表包含若干整數。
//輸出: IEnumerable<int>，包含所有數字對(a, b) 的和。
/*class Program
{
    static void Main()
    {
        List<int> integers = new List<int> { 1, 2, 3, 4 }; //組合不重複
        var result = CalculateAllPairsSum(integers);

        Console.WriteLine("所有數字對 (a, b) 的和:");
        foreach (var sum in result)
        {
            Console.WriteLine(sum);
        }
    }

    static IEnumerable<int> CalculateAllPairsSum(List<int> integers)
    {
        return integers.SelectMany((a, index) => integers.Skip(index + 1).Select(b => a + b));
    }
}*/




//題目 3 : 給定兩個字串列表，請找出這兩個列表中每個字串的交集（字母不分大小寫），並按交集元素數量從多到少排序。
//要求: 使用 LINQ 語法來實現。
//輸入: List<string>，list1 包含若干字串，list2 包含若干字串。
//輸出: IEnumerable < (string str1, string str2, int intersectionCount) >，每個元素是一個元組，包含 str1 和 str2 以及交集的元素數量。

/*class Program
{
    static void Main()
    {
        List<string> list1 = new List<string> { "hello", "NI", "YUCHIN" };
        List<string> list2 = new List<string> { "NI", "YU", "CHIN" };
        var result = FindStringIntersections(list1, list2);

        Console.WriteLine("列表中每個字串的交集:");
        foreach (var (str1, str2, count) in result)
        {
            Console.WriteLine($"({str1}, {str2}): {count}");
        }
    }

    static IEnumerable<(string str1, string str2, int intersectionCount)> FindStringIntersections(List<string> list1, List<string> list2)
    {
        return list1.SelectMany(str1 =>
                list2.Select(str2 => (
                    str1: str1,
                    str2: str2,
                    intersectionCount: str1.ToLower().Intersect(str2.ToLower()).Count()))
            )
            .OrderByDescending(result => result.intersectionCount);
    }
}*/





//題目 4 : 給定一個整數列表，請找到列表中最常見的三個數字，並按它們的頻率從高到低排序。
//要求: 使用 LINQ 語法來實現。
//輸入: List<int>，列表包含若干整數。
//輸出: IEnumerable < (int number, int frequency) >，包含列表中最常見的三個數字及其頻率，按頻率從高到低排序。
/*class Program
{
    static void Main()
    {
        List<int> integers = new List<int> { 1, 2, 2, 3, 3, 3, 4, 4, 4, 4, 5, 5, 5, 5, 5 };
        var result = FindTopThreeFrequentNumbers(integers);

        Console.WriteLine("最常見的三個數字:");
        foreach (var (number, frequency) in result)
        {
            Console.WriteLine($"數字 {number} 出現頻率: {frequency}");
        }
    }

    static IEnumerable<(int number, int frequency)> FindTopThreeFrequentNumbers(List<int> integers)
    {
        return integers
            .GroupBy(i => i)
            .OrderByDescending(group => group.Count())
            .Take(3)
            .Select(group => (number: group.Key, frequency: group.Count()));
    }
}*/




//題目 5 : 給定一個整數列表，請計算列表中所有元素的乘積，並返回這個乘積。
//要求: 使用 LINQ 語法來實現。
//輸入: List<int>，列表包含若干整數。
//輸出: long，列表中所有元素的乘積。
class Program
{
    static void Main()
    {
        List<int> integers = new List<int> { 2, 3, 4, 5 };
        var product = CalculateProduct(integers);

        Console.WriteLine($"列表中所有元素的乘積: {product}");
    }

    static long CalculateProduct(List<int> integers)
    {
        return integers.Aggregate(1L, (acc, num) => acc * num);
    }
}