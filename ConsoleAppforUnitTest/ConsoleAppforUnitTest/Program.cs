using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppforUnitTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class MyRectangle
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public double GetArea() 
        {
            return Width * Height; 
        }
    }
}
