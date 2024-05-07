using DelegateSample002;

namespace DelegateSample002
{
    public delegate bool MyPredicate(string value);
    public class MyClass
    {
        //public List<string> DoWhere(List<string> source,MyPredicate predicate)
        public List<string> DoWhere(List<string> source, Func<string, bool> predicate)
        {
            List<string> result = new List<string>();
            foreach (var item in source)
            {
                if (predicate.Invoke(item))
                {
                    result.Add(item);
                }
            }
            return result;
        }
    }
}

static bool SearchDavid(string value)
{
    return (value == "David");
}

static void Main(string[] args)
{
    List<string> source = new List<string> { "Bill", "John", "David", "Tom", "David"};
    MyClass obj = new MyClass();
    MyPredicate predicate = SearchDavid;
    // var result = obj.DoWhere(source, predicate);
    var result = obj.DoWhere(source, (x) => { return x == "David"; }); //改成Lambda
    foreach (var item in source)
    {
        Console.WriteLine(item);
    }
    Console.ReadLine();
}