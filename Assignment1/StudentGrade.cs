using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    enum grades {A=1, B, C, D, E, F}
    class StudentGrade
    {
        static void Main()
        {
            //int a = grades.A, b = grades.B, c = grades.C, d = grades.D, e = grades.E, f = grades.F;
            Console.WriteLine("Enter Student Marks");
            int marks = Convert.ToInt32(Console.ReadLine());

            if (marks >= 75)
                Console.WriteLine("Student Grade is:{0}", grades.A);
            else if (marks >= 65 && marks < 75)
                Console.WriteLine("Student Grade is:{0}", grades.B);
            else if (marks >= 55 && marks < 65)
                Console.WriteLine("Student Grade is:{0}", grades.C);
            else if (marks >= 45 && marks < 55)
                Console.WriteLine("Student Grade is:{0}", grades.D);
            else if (marks >= 35 && marks < 45)
                Console.WriteLine("Student Grade is:{0}", grades.E);
            else 
                Console.WriteLine("Student Grade is:{0}", grades.F);
            Console.ReadKey();
        }
    }
 
}
