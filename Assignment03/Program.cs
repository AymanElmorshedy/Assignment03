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

        #endregion
        Console.ReadKey();
    }

}

