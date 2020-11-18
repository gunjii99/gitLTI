using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    public delegate void EmpDel(string s); //delegate declaration
    //EmpDel can point to AcceptEmployee and DisplayEmployee because signature(return type and parameter type) are same
    //if signature is diff delegate wont point to that function
    class Employee
    {
        public static void AcceptEmployee(string name)
        {
            Console.WriteLine("Hello " + name);
        }

        public int getSal()
        {
            return 0;
        }
        public void DisplayEmployee(string msg)
        {
            Console.WriteLine(msg);
        }
    }
    class DelegateExample
    {
        public static void Main(string[] args)
        {
            Employee eobj = new Employee();
            EmpDel ed1 = new EmpDel(Employee.AcceptEmployee); //static method being given to a delegate
            ed1("Radha");

            EmpDel ed2 = new EmpDel(eobj.DisplayEmployee); //nonstatic method being given to a delegate
            ed2("Delegate Radha here");

            Console.ReadKey();
        }
        
    }
}
