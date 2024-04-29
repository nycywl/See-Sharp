using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // 顯示1~300，根據條件顯示不同的字串
            for (int i = 1; i <= 300; i++)
            {
                string output = "";

                if (i % 2 == 0)
                    output += "apple";
                if (i % 3 == 0)
                    output += "banana";
                if (i % 5 == 0)
                    output += "grape";
                if (i % 2 == 0 && i % 3 == 0)
                    output = "watermelon";
                if (i % 2 == 0 && i % 3 == 0 && i % 5 == 0)
                    output = "peach";

                if (output == "")
                    Console.WriteLine(i);
                else
                    Console.WriteLine(output);
            }

            // 將輸入的數列分成奇偶數數列並輸出
            Console.WriteLine("請輸入以逗號區隔的整數數列:");
            string input = Console.ReadLine();
            string[] numbers = input.Split(',');
            string oddNumbers = "";
            string evenNumbers = "";

            foreach (string number in numbers)
            {
                int num = int.Parse(number);
                if (num % 2 == 0)
                    evenNumbers += num + ",";
                else
                    oddNumbers += num + ",";
            }

            Console.WriteLine("奇數: " + oddNumbers.TrimEnd(','));
            Console.WriteLine("偶數: " + evenNumbers.TrimEnd(','));

            // 計算生命靈數
            Console.WriteLine("請輸入西元的出生年月日(YYYYMMDD):");
            string birthday = Console.ReadLine();
            int lifePathNumber = CalculateLifePathNumber(birthday);
            Console.WriteLine("生命靈數: " + lifePathNumber);
        }

        static int CalculateLifePathNumber(string birthday)
        {
            int sum = 0;
            foreach (char digit in birthday)
            {
                if (char.IsDigit(digit))
                {
                    sum += int.Parse(digit.ToString());
                }
            }

            while (sum > 9)
            {
                int tempSum = 0;
                while (sum > 0)
                {
                    tempSum += sum % 10;
                    sum /= 10;
                }
                sum = tempSum;
            }

            return sum;
        }
    }
}
