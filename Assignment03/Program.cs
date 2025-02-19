using static Assignment03.ListGenerator;

namespace Assignment03;

internal class Program
{
    static void Main(string[] args)
    {
        #region Partisiong Operators
        #region Q01
        var result = CustomersList.Where(c=>c.Region== "WA")
            .SelectMany(c=>c.Orders).Take(3);
        foreach(var item in result)
            Console.WriteLine(item);
        #endregion

        #endregion
        Console.ReadKey();
    }

}

