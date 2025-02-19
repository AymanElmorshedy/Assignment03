using System.ComponentModel;
using static Assignment03.ListGenerator;

namespace Assignment03;

internal class Program
{
    static void Main(string[] args)
    {
        #region Partisiong Operators
        #region Q01
        //var result = CustomersList.Where(c => c.Region == "WA")
        //    .SelectMany(c => c.Orders).Take(3);
        //foreach (var item in result)
        //    Console.WriteLine(item);
        #endregion

        #region Q02
        //var result = CustomersList.Where(c => c.Region == "WA")
        //    .SelectMany(c => c.Orders).Skip(2);
        //foreach (var item in result)
        //    Console.WriteLine(item);
        #endregion

        #region Q03
        //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
        //var result = numbers.TakeWhile((n, i) => n > i);
        //foreach (int n in result)
        //{
        //    Console.WriteLine($"{n} ");
        //}
        #endregion

        #region Q04
        //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
        //var result = numbers.SkipWhile(n=>n%3!=0);
        //foreach (var number in result)
        //{
        //    Console.Write($"{number} ");
        //}
        #endregion

        #region Q05
        //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

        //var result = numbers.SkipWhile((n, i) => n > i);
        //foreach (int n in result)
        //{
        //    Console.Write($"{n} ");
        //}
        #endregion

        #endregion

        #region Quantifiers Operators
        #region Q01

        #endregion

        #region Q02
        //var result = ProductsList.Where(p => p.UnitsInStock == 0).GroupBy(p => p.Category).Select(g => new
        //{
        //    Category = g.Key,
        //    Products = g.ToList()
        //});
        //foreach (var category in result)
        //{
        //    Console.WriteLine($"Category: {category.Category}");
        //    foreach (var product in category.Products)
        //    {
        //        Console.WriteLine($"   - {product.ProductName} ");
        //    }
        //}
        #endregion

        #region Q03
        var result = ProductsList.Where(p => p.UnitsInStock > 0)
            .GroupBy(p => p.Category);
        foreach (var item in result)
        {
            Console.WriteLine(item.Key);

            foreach(var g in item)
                Console.WriteLine($"    {g}");
        }
        #endregion
        #endregion
        Console.ReadKey();
    }

}

