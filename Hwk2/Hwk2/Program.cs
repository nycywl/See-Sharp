using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Part 1: 轉換句子大小寫
            Console.WriteLine("請輸入一個英文句子：");
            string inputSentence = Console.ReadLine();

            string upperCaseSentence = inputSentence.ToUpper();
            string lowerCaseSentence = inputSentence.ToLower();

            Console.WriteLine($"全部變大寫：{upperCaseSentence}");
            Console.WriteLine($"全部變小寫：{lowerCaseSentence}");

            // Part 2: 產生隨機數字並計算總和及平均值
            Random random = new Random();
            int[] numbers = new int[3];
            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(1, 11); // 1~10之間的隨機數字
                sum += numbers[i];
            }

            double average = (double)sum / numbers.Length;
            double roundedAverage = Math.Round(average, 2);

            Console.WriteLine($"隨機產生的數字：{string.Join(", ", numbers)}");
            Console.WriteLine($"總和：{sum}");
            Console.WriteLine($"平均值：{roundedAverage}");

            // Part 3: 計算日期之間的差距
            Console.WriteLine("請輸入第一個日期的年月日（格式：yyyy-MM-dd）：");
            DateTime date1 = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("請輸入第二個日期的年月日（格式：yyyy-MM-dd）：");
            DateTime date2 = DateTime.Parse(Console.ReadLine());

            TimeSpan difference = date2 - date1;
            int daysDifference = (int)difference.TotalDays;

            Console.WriteLine($"兩個日期之間相差 {daysDifference} 天。");

            Console.ReadLine(); // 等待使用者按下 Enter 鍵後結束程式
        }
    }
}

