using LinqEx;
using System.Collections.Generic;
using System.IO;

public static class FileHelper
{
    public static List<Product> LoadProductsFromCsv(string filePath)
    {
        var products = new List<Product>();
        using (var reader = new StreamReader(filePath))
        {
            string line;
            reader.ReadLine();

            while ((line = reader.ReadLine()) != null)
            {
                var fields = line.Split(',');
                var product = new Product
                {
                    Id = fields[0],
                    Name = fields[1],
                    Quantity = int.Parse(fields[2]),
                    Price = decimal.Parse(fields[3]),
                    Category = fields[4]
                };

                products.Add(product);
            }
        }

        return products;
    }
}
