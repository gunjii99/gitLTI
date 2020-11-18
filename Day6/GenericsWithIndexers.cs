using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    class GenericsWithIndexers<T> //where T: class//restrictions on generics add: where T : class
        //restrictions can only be reference type not any value type
    {
        private T[] data = new T[3];
        private T var;
        private string name;

        public string Name //private data member invoked through indexer
        {
            get { return name; }
            set { name = value; }
        }

        public T Var
        {
            get { return var; }
            set { var = value; }
        }

        public T this[int index] //generic indexer
        {
            get { return data[index]; }
            set { data[index] = value; }
        }

        public T this[float index] //generic indexer
        {
            get { return data[(int)index]; }
            set { data[(int)index] = value; }
        }

        public T this[string index] //generic indexer
        {
            get { return data[1]; }
            set { data[1] = value; }
        }

    }

    class Driver
    {
        public static void Main(string[] args)
        {
            GenericsWithIndexers<float> gwi = new GenericsWithIndexers<float>();
            gwi[0] = 5.5f;
            gwi[1.0f] = 10.1f;
            gwi[2] = 15.5f;

            //since class is float all its generic memebers will become float
            gwi.Var = 1.5f;

            gwi.Name = "LNT"; //this is normal data member, declared as string

            Console.WriteLine("Pos 1: " + gwi[0]);
            Console.WriteLine("Pos 2: " + gwi[1.0f]);
            Console.WriteLine("Pos 3: " + gwi[2]);
            Console.WriteLine("Generic variable: " + gwi.Var);
            Console.WriteLine("Normal variable: " + gwi.Name);
            Console.ReadKey();
        }
    }
}
