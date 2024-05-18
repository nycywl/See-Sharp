using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // 載入產品清單
        var products = FileHelper.LoadProductsFromCsv("product.csv");

        // 計算所有商品的總價格
        var totalPrice = products.Sum(p => p.Price * p.Quantity);
        Console.WriteLine($"所有商品的總價格: {totalPrice:C}");

        // 計算所有商品的平均價格
        var averagePrice = products.Average(p => p.Price);
        Console.WriteLine($"所有商品的平均價格: {averagePrice:C}");

        // 計算商品的總數量
        var totalQuantity = products.Sum(p => p.Quantity);
        Console.WriteLine($"商品的總數量: {totalQuantity}");

        // 計算商品的平均數量(四捨五入至個位數)
        var averageQuantity = Math.Round(products.Average(p => p.Quantity));
        Console.WriteLine($"商品的平均數量: {averageQuantity}");

        // 找出最貴的商品
        var mostExpensiveProduct = products.OrderByDescending(p => p.Price).First();
        Console.WriteLine($"最貴的商品: {mostExpensiveProduct}");

        // 找出最便宜的商品
        var cheapestProduct = products.OrderBy(p => p.Price).First();
        Console.WriteLine($"最便宜的商品: {cheapestProduct}");

        // 計算 3C 商品總價
        var total3CPrice = products.Where(p => p.Category == "3C").Sum(p => p.Price * p.Quantity);
        Console.WriteLine($"3C 商品總價: {total3CPrice:C}");

        // 計算飲料和食品商品總價
        var totalBeverageFoodPrice = products
            .Where(p => p.Category == "飲料" || p.Category == "食品")
            .Sum(p => p.Price * p.Quantity);
        Console.WriteLine($"飲料及食品商品總價: {totalBeverageFoodPrice:C}");

        // 找出各個商品類別底下價格大於 1000 的商品
        var expensiveProductsByCategory = products
            .Where(p => p.Price > 1000)
            .GroupBy(p => p.Category);

        foreach (var group in expensiveProductsByCategory)
        {
            Console.WriteLine($"類別 {group.Key} 中價格大於 1000 的商品:");
            foreach (var product in group)
            {
                Console.WriteLine(product);
            }

            if (!group.Any())
            {
                Console.WriteLine($"找不到價格大於 1000 的商品");
            }
        }

        // 計算各類別價格大於 1000 的商品的平均價格
        foreach (var group in expensiveProductsByCategory)
        {
            var averageExpensivePrice = group.Any() ? group.Average(p => p.Price) : 0;
            Console.WriteLine($"類別 {group.Key} 中價格大於 1000 的商品的平均價格: {averageExpensivePrice:C}");
        }

        // 按照商品價格由高到低排序
        var productsByPrice = products.OrderByDescending(p => p.Price);
        Console.WriteLine("\n商品價格由高到低排序:");
        foreach (var product in productsByPrice)
        {
            Console.WriteLine(product);
        }

        // 按照商品數量由低到高排序
        var productsByQuantity = products.OrderBy(p => p.Quantity);
        Console.WriteLine("\n商品數量由低到高排序:");
        foreach (var product in productsByQuantity)
        {
            Console.WriteLine(product);
        }

        // 找出各商品類別底下最貴的商品
        var mostExpensiveByCategory = products
            .GroupBy(p => p.Category)
            .Select(g => new
            {
                Category = g.Key,
                Product = g.OrderByDescending(p => p.Price).FirstOrDefault()
            });

        Console.WriteLine("\n各商品類別底下最貴的商品:");
        foreach (var item in mostExpensiveByCategory)
        {
            Console.WriteLine($"類別 {item.Category}: {item.Product}");
        }

        // 找出各商品類別底下最便宜的商品
        var cheapestByCategory = products
            .GroupBy(p => p.Category)
            .Select(g => new
            {
                Category = g.Key,
                Product = g.OrderBy(p => p.Price).FirstOrDefault()
            });

        Console.WriteLine("\n各商品類別底下最便宜的商品:");
        foreach (var item in cheapestByCategory)
        {
            Console.WriteLine($"類別 {item.Category}: {item.Product}");
        }

        // 列出所有商品(一頁 4 筆，共 5 頁)
        int itemsPerPage = 4;
        int totalPages = (int)Math.Ceiling((double)products.Count / itemsPerPage);

        while (true)
        {
            Console.WriteLine($"\n請輸入你想看的頁碼 (1 - {totalPages})，或輸入 0 退出:");
            if (int.TryParse(Console.ReadLine(), out int page) && page >= 0 && page <= totalPages)
            {
                if (page == 0)
                {
                    break;
                }

                Console.WriteLine($"\n第 {page} 頁:");

                var pagedProducts = products
                    .Skip((page - 1) * itemsPerPage)
                    .Take(itemsPerPage);

                foreach (var product in pagedProducts)
                {
                    Console.WriteLine(product);
                }
            }
            else
            {
                Console.WriteLine("無效的頁碼，請輸入有效的頁碼。");
            }
        }
    }
}
