using ExtensionSample001.Helpers;

namespace ExtensionSample001.Helpers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var source = new List<string> { "Bill", "John", "David", "Tom", "David" };
            var result = source.DoWhere(x => x == "Tom");
            source.Min
        }
    }

    public static class MyClass 
    { 
        public static IEnumerable<T> DoWhere<T>(this IEnumerable<T> source, Func<T, bool> predicate) 
        {
            List<T> result = new List<T>();
            foreach( var item in source)
            {
                if (predicate.Invoke(item))
                {
                    yield return item;
                }
            }
        }
        public static IEnumerable<TResult> MySelect<TSource, TRsult>(this IEnumerable<TSource> source, Func<TSource, TResult> selector)
        {
            foreach( var item in source)
            {
                yield return selector.Invoke(item);
            }
        }

        public static int MySum<TSource>(this IEnumerable<TSource> source, Func<TSource, int> selector)
        {
            int result = 0;
            foreach (var item in source)
            {
                result = result + selector.Invoke(item);
            }
            return result;
        }

        public static int Min<TSource>(this IEnumerable<TSource> source, Func<TSource, int> selector)
        {
            int result = int.MaxValue;
            foreach (var item in source)
            {
                var temp = selector.Invoke(item);
                if(temp < result)
                {
                    result = temp;
                }
            }
            return result;
        }
    }
}
