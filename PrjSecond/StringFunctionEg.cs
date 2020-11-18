using System;
using System.Collections.Generic;
using System.Text;

namespace PrjSecond
{
    class StringFunctionEg
    {
        static void Main()
        {
            string name = Console.ReadLine();
            Console.WriteLine("Name in upper:{0}", name.ToUpper());
            Console.WriteLine("Name in lower:{0}", name.ToLower());
            Console.WriteLine("Name in upper:{0}", name.Length);
            bool iscontains = name.Contains("UP");
            Console.WriteLine("Name contains UP?:{0}", iscontains);
            Console.WriteLine("Substring:{0}", name.Substring(3, 5));
            Console.ReadKey();

        }
    }
}
