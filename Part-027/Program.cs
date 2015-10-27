using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Part_027
{
    /// <summary>
    /// Part 027 : Properties in C#.
    /// </summary>
    class Program
    {
        /*
         * 1. In C# to encapsulate and protect class fields, we use properties.
         * 2. We use get; and set; accessors to implement properties.
         * 3. A property with both get; and set; accessor is read/write property.
         * 4. A property with only get; accessor is read only property.
         * 5. A property with only set; accessor is write only property.
         * 
         */
        static void Main(string[] args)
        {
            SchoolStudent ss = new SchoolStudent();
            ss.ID = 04;
            ss.Name = "Anand Dev";
            // ss.Email = "a@b.com";
            // ss.PassMarks = 0; It will give error.
            Console.WriteLine(" Id = {0}, Name = {1}, Pass marks = {2}", ss.ID, ss.Name, ss.PassMarks);
        }
    }

    public class SchoolStudent
    {
        private int _id;
        private String _name;
        private int _passMarks = 35;        

        public int ID
        {
            get { return this._id; }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Student Id can't be negative.");
                }
                this._id = value;
            }

        }

        public String Name
        {
            get { return String.IsNullOrEmpty(this._name) ? "No Name" : this._name; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new Exception("Name can't be null or empty.");
                }
                this._name = value;
            }
        }

        public int PassMarks
        {
            get { return this._passMarks; }
        }

        // This is example of auto implemented property. The compiler will auomatically create private field of this property.
        public String Email{ get; set; }

    }
}
