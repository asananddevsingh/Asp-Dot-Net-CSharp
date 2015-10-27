using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Part_028
{
    /// <summary>
    /// Part 028 : Structs. (Similarities)
    /// </summary>
    class Program
    {
        /*
         * Just like classes, structs can have
         * 1. Private fields.
         * 2. Public properties.
         * 3. Constructors.
         * 4. Methods.
         * 
         * NOTE :: Object initializer syntext, which is got introduced in C# 3.0 can be used either for class or for struct.
         */
        static void Main(string[] args)
        {
            Customer c = new Customer(04, "Anand Dev");
            c.Print();

            Customer c2 = new Customer();
            c2.Print();

            Customer c3 = new Customer();
            c3.ID = 14;
            c3.Name = "Dev Singh";
            c3.Print();

            // This is object initializer syntext, which is got introduced in C# 3.0
            Customer c4 = new Customer { ID = 24, Name = "Sahil" };
            c4.Print();

            Console.ReadKey();
        }
    }

    public struct Customer
    {
        private int _id;
        private String _name;

        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int ID { get { return this._id; } set { this._id = value; } }

        public Customer(int id, String name)
        {
            this._id = id;
            this._name = name;
        }

        public void Print()
        {
            Console.WriteLine("ID = {0}, Name = {1}", this._id, this._name);
        }
    }


}

