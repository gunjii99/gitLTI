using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace flowcontrol
{
    class Switcheg
    {
        static void Main()
        {
            int choice;
            string username;
            int batchno;
            Console.WriteLine("1.Add User Details 2.Update user details 3.No change 4.quit");
            Console.WriteLine("please enter your choice:");

            choice = Convert.ToInt32(Console.ReadLine());

            do
            {
                switch (choice)
                {
                    case 1:

                        username = Console.ReadLine();
                        batchno = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("{0} , {1}", username, batchno);
                        break;

                    case 2:
                        username = Console.ReadLine();
                        batchno = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("updated user details {0} , {1}", username, batchno);
                        break;

                    case 3:
                        Console.WriteLine("No Change");
                        break;

                    case 4:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Please enter a valid input");
                        break;
                }
            } while (choice == 4);
        }
    }
}
