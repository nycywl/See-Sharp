using System;

class Program
{
    static void Main(string[] args)
    {
        // 第一題
        Console.WriteLine("請輸入兩個數字，以逗號分隔：");
        string[] numbersInput = Console.ReadLine().Split(',');
        if (numbersInput.Length == 2 && double.TryParse(numbersInput[0], out double num1) && double.TryParse(numbersInput[1], out double num2))
        {
            double add = num1 + num2;
            double subtract = num1 - num2;
            double multiply = num1 * num2;
            double divide = num1 / num2;

            Console.WriteLine(string.Format("{0}+{1}={2}; {0}-{1}={3}; {0}*{1}={4}; {0}/{1}={5}", num1, num2, add, subtract, multiply, divide));
        }
        else
        {
            Console.WriteLine("輸入格式錯誤，請輸入兩個有效數字。");
        }

        // 第二題
        Console.WriteLine("請輸入身高(公尺)及體重(公斤)，以逗號分隔：");
        string[] bmiInput = Console.ReadLine().Split(',');
        if (bmiInput.Length == 2 && double.TryParse(bmiInput[0], out double height) && double.TryParse(bmiInput[1], out double weight))
        {
            double bmi = weight / (height * height);
            Console.WriteLine($"你的BMI為 {bmi:F2}");
        }
        else
        {
            Console.WriteLine("輸入格式錯誤，請輸入有效的身高和體重。");
        }

        // 第三題
        Console.WriteLine("請輸入攝氏溫度：");
        if (double.TryParse(Console.ReadLine(), out double celsius))
        {
            double fahrenheit = celsius * 9 / 5 + 32;
            double kelvin = celsius + 273.15;
            Console.WriteLine(string.Format("{0}°C = {1}°F = {2:F2}K", celsius, fahrenheit, kelvin));
        }
        else
        {
            Console.WriteLine("輸入格式錯誤，請輸入有效的溫度。");
        }
    }
}
