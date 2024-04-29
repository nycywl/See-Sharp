using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // 判斷輸入的數字是奇數還是偶數
            Console.WriteLine("請輸入一個數字：");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine($"{number} 是偶數。");
            }
            else
            {
                Console.WriteLine($"{number} 是奇數。");
            }

            // 判斷輸入的年份是否為閏年
            Console.WriteLine("請輸入一個西元年份：");
            int year = Convert.ToInt32(Console.ReadLine());
            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {
                Console.WriteLine($"{year} 年是閏年。");
            }
            else
            {
                Console.WriteLine($"{year} 年不是閏年。");
            }

            // 計算電費
            Console.WriteLine("請輸入用電度數：");
            double electricityUsage = Convert.ToDouble(Console.ReadLine());
            double electricityFee = 0;
            if (electricityUsage <= 120)
            {
                electricityFee = electricityUsage * 1.63;
            }
            else if (electricityUsage <= 330)
            {
                electricityFee = 120 * 1.63 + (electricityUsage - 120) * 2.38;
            }
            else if (electricityUsage <= 500)
            {
                electricityFee = 120 * 1.63 + 210 * 2.38 + (electricityUsage - 330) * 3.52;
            }
            else if (electricityUsage <= 700)
            {
                electricityFee = 120 * 1.63 + 210 * 2.38 + 170 * 3.52 + (electricityUsage - 500) * 4.80;
            }
            else if (electricityUsage <= 1000)
            {
                electricityFee = 120 * 1.63 + 210 * 2.38 + 170 * 3.52 + 200 * 4.80 + (electricityUsage - 700) * 5.66;
            }
            else
            {
                electricityFee = 120 * 1.63 + 210 * 2.38 + 170 * 3.52 + 200 * 4.80 + 300 * 5.66 + (electricityUsage - 1000) * 6.41;
            }

            // 將電費四捨五入至個位數
            electricityFee = Math.Round(electricityFee, MidpointRounding.AwayFromZero);

            Console.WriteLine($"應繳之電費為：{electricityFee} 元。");

            Console.ReadLine(); // 等待使用者按下 Enter 鍵後結束程式
        }
    }
}
