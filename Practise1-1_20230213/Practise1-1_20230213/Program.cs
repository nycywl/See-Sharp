using System.ComponentModel;

namespace TaskStatus 
{
    /*internal class Program 
    {
        private static int x;
        private int y;
        static void Main(string[] args) 
        {
            Add(8, 9);
            Console.ReadLine();
        }

        static int Add(int a, int b) 
        {
            return a + b;
        }

        static int Add() 
        {
            return 8 + 9;
        }
    }*/




    /*public class MyClass 
    {
        private int x;
        private int y;

        public MyClass()
        {
            x = 0;
            y = 0;
        }

        public MyClass(int x, int y) 
        {
            x = 0;
            y = 0;
            x = x;
            y = y;
        }
    }*/

    /*public class MyClass
    {
        private int x;
        private int y;

        public MyClass() : this(0,0)
        {
        }

        public MyClass(int x, int y)
        {
            x = x;
            y = y;
        }
    }*/
    /*class Program
    {
        static void Main(string[] args)
        {
            BaseClass o1 = new BaseClass();
            Display("o1", o1.X);

            BaseClass o2 = new BaseClass(99);
            Display("o2", o2.X);

            Console.ReadLine();
        }

        static void Display(string name, int value)
        {
            Console.WriteLine($"{name}的 x 是 {value}");
        }
    }*/

    /*public class BaseClass
    {
        public int X { get; private set; }

        public BaseClass() : this(0) { }

        public BaseClass(int y) 
        {
            X = y;
        }
    }

    public class Class1 : BaseClass 
    {
        public int K { get; set; }
        public Class1 (int x, int y) : base(y)
        {
            K = x;
        }
    }*/


    class Program 
    {
        static void Main(string[] args)
        {
            BaseClass o1 = new BaseClass();
            Display("o1", o1.X);

            BaseClass o2 = new BaseClass(99);
            Display("o2", o2.X);

            Class1 o3 = new Class1(55, 77);
            Display("o3", o3.X, o3.K);

            Console.ReadLine();
        }

        static void Display(string name, int value)
        {
            Console.WriteLine($"{name}的 x 是 {value}");
        }
        static void Display(string name, int v1, int v2)
        {
            Console.WriteLine($"{name}的 x 是 {v1} , K 是 {v2}");
        }
    }

    public class BaseClass
    {
        public int X { get; private set; }

        public BaseClass() : this(0) { }

        public BaseClass(int y)
        {
            X = y;
        }
    }

    public class Class1 : BaseClass
    {
        public int K { get; set; }
        public Class1(int x, int y) : base(y)
        {
            K = x;
        }
    }
}
