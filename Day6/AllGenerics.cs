using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    class AllGenerics<T> //generic class
    {
        private T genericmember;

        public AllGenerics(T val) //generic constructor
        {
            genericmember = val;
        }

        public T Genericmemeber { get; set; } //generic property

        public T genericMethod(T genericParameter) //method with generic return type
        {
            Console.WriteLine("Parameter type : {0}, Vlaue: {1}", typeof(T).ToString(), genericParameter);
            Console.WriteLine("Return type : {0}, Vlaue: {1}", typeof(T).ToString(), genericParameter);
            //return type / parameter type depends on class type declared while initializing the class
            return genericmember;
        }
    }

    class Test
    {
        public static void Main(string[] args)
        {
            AllGenerics<int> alg = new AllGenerics<int>(400);
            int x = alg.genericMethod(200);

            AllGenerics<string> algstr = new AllGenerics<string>("My string");
            string s = algstr.genericMethod("200");

            Console.ReadKey();

        }
    }
}
