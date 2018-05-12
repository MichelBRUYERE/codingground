using System.IO;
using System;
using System.Globalization;
class Program
{
    static void Main()
    {
        Int16 a=123;
        //Console.WriteLine(a.ToString("$0", CultureInfo.CreateSpecificCulture("fr-BE")));
	
        Console.WriteLine("{0:C0}",a, CultureInfo.CreateSpecificCulture("fr-FR"));
    }
}
