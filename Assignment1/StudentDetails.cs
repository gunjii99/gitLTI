using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    class StudentDetails
    {
        static void Main()
        {
            Console.WriteLine("Please enter Student Details:Student Name, Roll No, Batch");
            string StudentName = Console.ReadLine();
            int StudentRollno = Convert.ToInt32(Console.ReadLine()), StudentBatch = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Student Name:{0}",StudentName);
            Console.WriteLine("Student Roll No:{0}",StudentRollno);
            Console.WriteLine("Student Batch:{0}",StudentBatch);
        }
    }
}
