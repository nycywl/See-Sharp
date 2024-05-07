using AllClassSample002;
using static AllClassSample002.BaseClass;

static void Main(string[] args)
{
    BaseClass o1 = new Class1();
    o1.Execute();
    o1.Begin();

    BaseClass o2 = new Class2();
    o2.Execute();
    o2.Begin();

    Console.ReadLine();
}