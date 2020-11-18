using System;
using System.Collections.Generic;
using System.Text;

namespace flowcontrol
{
    class ForeachEg
    {
        static void Main()
        {
            string[] Gender = {"male","FEMALE","Male","female","MALE" };
            int m = 0, f = 0;
            foreach(string g in Gender)
            {
                if (g.ToLower() =="male")
                {
                    m++;
                }
                else if (g.ToLower() == "female")
                {
                    f++;
                }
            }

            Console.WriteLine("Number of Males {0}",m);
            Console.WriteLine("Number of Females {0}", f);
        }
    }
}
