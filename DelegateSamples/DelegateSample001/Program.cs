using DelegateSample001;

namespace DelegateSample001
{
    public delegate void SomeAction(string message);
    class Program
    {
        static void Main(string[] args)
        {
            SomeAction action1 = new SomeAction(ShowText);
            action1 += ShowMessage;
            SomeAction action2 = ShowText;
            action1.Invoke("第一個");
            action2("第二個");
            Console.ReadLine();
        }
        static void ShowText(object msg)
        {
            Console.WriteLine($"ShowText {msg}");
        }
        static void ShowMessage(string str)
        {
            Console.WriteLine($"ShowMessage {str}");
        }
        static void ShowNumber(int i)
        {
            Console.WriteLine($"ShowText {i}");
        }
    }
}



