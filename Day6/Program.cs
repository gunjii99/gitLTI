using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    class GenDay6 //general/normal class
    {
        public void Show<T>(string msg, T val) //generic method
        {
            Console.WriteLine("{0} :{1}", msg, val); 
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            GenDay6 g6 = new GenDay6();

            //calling generic method
            g6.Show<int>("Integer", 125);

            g6.Show<char>("Integer", 'A');

            g6.Show<double>("Double", 125.68);

            Console.ReadKey();
        }
    }
}
