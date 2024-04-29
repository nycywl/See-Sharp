/*using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;*/

namespace PractiseOne
{
    internal class Program
    {
        private static int x;
        private int y;
        //public const int NUMBER = 100;

        //Program p = new Program();

        static void Main(string[] args)
        {
            /* Dictionary<string, int> _dictionary = new Dictionary<string, int>
             {
                 {"A",100 },
                 {"B",200 },
                 {"C",300 }
             };

             int result = 0;
             if (_dictionary.ContainsKey("D")) 
             {
                 result = _dictionary["A"];
                 Console.WriteLine($"找到的值是 {result}");  //$ 字串插補
             }
             else
             {
                 Console.WriteLine("查無此key");
             }*/
            //List<string> list = new List<string> { "dog", "cat", "fly", "donkey"};
            /*string result = list.Find((x) => x == "cat");*/ //(x) => x == "cat Lambda 入
            /*string result = list.FindLast((x) => x.Contains("d"));*/
            /*List<string> result = list.FindAll((x) => x.Contains("d"));
            string display = string.Join("#", result);*/
            //Console.WriteLine(result.ToString());
            //Console.WriteLine(result);
            /*foreach (string item in result)
            {
                Console.WriteLine(item);
            }*/
            //Console.WriteLine(display);
            //Console.WriteLine(string.Join("#", result));

            /*Program.x = 10;
            Program.Do();
            Program p = new Program();

            p.Exec();*/
            /*Program a1 = new Program();
            Program a2 = new Program();*/
            //Console.WriteLine();

            /*MyClass o1 = new MyClass();
            int r = o1.Number;
            o1.Number = 999;
            Console.WriteLine(o1.Number);*/

            /*int y = 999;
            Do(y);*/
            Add(8, 9);
            Console.ReadLine();
        }

        /*static void Do() {}

        void Exec() 
        {
            Program.Do();
        }*/

        /*static string Do(int x) 
        {
            return x.ToString();
        }*/

        static int Add(int a, int b) 
        {
            return a + b;
        }
        static int Add()
        {
            return 8 + 9;
        }
    }

    public class MyClass 
    {
        private int number;
        public int Number 
        {
            get
            {
                return number;
            }
            set 
            { 
                if (value > 100) 
                {
                    value = 100;
                }
                number = value; 
            } 
        }
    }

}
