using System;
using System.Linq;

namespace GuessNumberGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool playAgain = true;

            Console.WriteLine("歡迎來到1A2B猜數字的遊戲～");

            while (playAgain)
            {
                // 產生一組 0 到 9 之間的 4 個不重複的數字
                int[] answer = Enumerable.Range(0, 10)
                                         .OrderBy(x => random.Next())
                                         .Take(4)
                                         .ToArray();

                bool guessedCorrectly = false;

                while (!guessedCorrectly)
                {
                    Console.WriteLine("請輸入4個數字：");
                    string guess = Console.ReadLine();

                    // 判斷使用者的輸入是否為 4 位數字且不重複
                    if (guess.Length != 4 || guess.Distinct().Count() != 4 || !guess.All(char.IsDigit))
                    {
                        Console.WriteLine("請輸入正確格式的4個不同數字。");
                        continue;
                    }

                    // 將輸入轉換為數字陣列
                    int[] guessNumbers = guess.Select(ch => int.Parse(ch.ToString())).ToArray();

                    // 計算 A 和 B 的數量
                    int aCount = 0;
                    int bCount = 0;

                    for (int i = 0; i < 4; i++)
                    {
                        if (guessNumbers[i] == answer[i])
                        {
                            aCount++;
                        }
                        else if (answer.Contains(guessNumbers[i]))
                        {
                            bCount++;
                        }
                    }

                    // 顯示判定結果
                    Console.WriteLine($"判定結果是{aCount}A{bCount}B");

                    // 如果猜對了
                    if (aCount == 4)
                    {
                        Console.WriteLine("4A0B 恭喜你！猜對了！！");
                        guessedCorrectly = true;
                    }
                }

                // 詢問使用者是否要繼續玩
                Console.WriteLine("你要繼續玩嗎？(y/n):");
                string response = Console.ReadLine();

                if (response.Trim().ToLower() != "y")
                {
                    playAgain = false;
                }
            }

            Console.WriteLine("遊戲結束，下次再來玩喔～");
        }
    }
}
