using System;

namespace LinqEx
{
    public class Product
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }

        public override string ToString()
        {
            return $"{Id} | {Name} | {Quantity} | {Price:C} | {Category}";
        }
    }
}
