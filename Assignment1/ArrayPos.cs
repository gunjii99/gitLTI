using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    class ArrayPos
    {
        static void Main()
        {
            int[] Array1 = { 6, 7, 9, 1, 4, 5 };
            Console.WriteLine("Please input number:");
            int num = Convert.ToInt32(Console.ReadLine());
            int i ;
            for (i =0 ; i<Array1.Length; i++)
            {
                if (num == Array1[i])
                {
                    Console.WriteLine("Position is {0}", i);
                }
            }

            if (i == Array1.Length - 1)
            {
                Console.WriteLine("Input not found");
            }

        }
    }
}
