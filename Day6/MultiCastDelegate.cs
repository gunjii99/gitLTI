using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    public delegate int delcal(int x);

    class sample
    {
        static int p;

        public int Square(int a)
        {
            p = a * a;
            Console.WriteLine("dc1: " + p);
            return p;
        }
        public int triple(int q)
        {
            p = q * q * q;
            Console.WriteLine("dc2: " + p);
            return p;
        }
    }
    class MultiCastDelegate
    {
        public static void Main(string[] args)
        {
            sample s = new sample();
            delcal dc1 = new delcal(s.Square);
            delcal dc2 = new delcal(s.triple);
            delcal dcall;
            dcall = dc1 + dc2; //multicast delegates

            int result = dcall(5);
            Console.WriteLine(result); //multicast retains only last called delegate ie. it retained only dc2 when dc1+dc2 is called


            Console.ReadKey();
        }
        
    }
}
