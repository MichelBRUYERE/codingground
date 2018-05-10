using System.IO;
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("{0:N0}",Factorial(27));
    }
    public static decimal Factorial(int n)
    {
        if (n == 0)//The condition that limites the method for calling itself
            return 1;
            try
            {
                return n * Factorial(n - 1);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }
    }
}
