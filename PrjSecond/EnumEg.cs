using System;
using System.Collections.Generic;
using System.Text;

namespace PrjSecond
{
    //Enumeration - special set of named values
    //float,integer,byte,double,etc
    enum feedback {Poor =1, Fair, Good, VeryGood, Excellent }
    class EnumEg
    {
        static void  Main()
        {
            int worstfeedback = Convert.ToInt32(feedback.Poor);
            Console.WriteLine("Excellent: {0}", (int)feedback.Excellent);
            Console.WriteLine("Worst Feedback: {0}", worstfeedback);
            Console.ReadKey();
        }
    }
}
