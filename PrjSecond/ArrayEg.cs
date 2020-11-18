using System;
using System.Collections.Generic;
using System.Text;

namespace PrjSecond
{
    class ArrayEg
    {
        static void Main()
        {
            //Single Dimensional Array
            //datatype[] arrayname=new datatype[size];
            /*string[] Fruits = new string[5];


            for (int i = 0; i < Fruits.Length; i++)
            {
                Console.Write("Enter Fruit  Name of index {0}", i);
                Fruits[i] = Console.ReadLine();
            }
            Array.Sort(Fruits);
            Console.WriteLine("Sorted Array");
            for (int i = 0; i < Fruits.Length; i++)
            {
                Console.WriteLine("Enter Fruit  Name of index {0} :{1}", i, Fruits[i]);

            }*/

            //multi dimensional array
            int[,] TwoDarray = new int[3, 3];
            int[,] TwoD = new int[,] { { 2, 3 }, { 4, 5 } }; //static 2d array

            Console.WriteLine("enter values:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    TwoDarray[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Array:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(TwoDarray[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.Read();
        }
    }
}
