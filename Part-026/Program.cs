using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Part_026
{
    /// <summary>
    /// Part 026: Why properties. ?
    /// </summary>
    class Program
    {
        /*
         * Marking the class field public and exposing to the external world is bad. 
         * As you will not have control over what get assigned and get returned. Example id of student can't be negative.
         */
        static void Main(string[] args)
        {
            /*
             * Here we can assign any garbage value to the class fields. Which is wrong.
             */
            Student s1 = new Student();
            s1.id = -1;
            s1.name = null;
            s1.passMarks = 0;
            Console.WriteLine(" Id = {0}, Name = {1}, Pass marks = {2}", s1.id, s1.name, s1.passMarks);

            SchoolStudent ss = new SchoolStudent();
            // ss.SetId(-1); This will throw exception.
            // ss.SetName(null); This will throw exception.
            ss.SetId(01);
            ss.SetName("Anand Dev");
            Console.WriteLine(" Id = {0}, Name = {1}, Pass marks = {2}", ss.GetId(), ss.GetName(), ss.GetPassMarks());

        }
    }

    /*
     * Our Requirement ::
     * 1. ID should always be non-negative.
     * 2. Name can't be null.
     * 3. If student name is missing, print "No name".
     * 4. Pass marks should be only readable.
     */

    #region This is wrong way
    public class Student
    {
        public int id;
        public String name;
        public int passMarks = 35;
    }
    #endregion

    #region This is right way
    public class SchoolStudent
    {
        private int _id;
        private String _name;
        private int _passMarks = 35;

        public void SetId(int id)
        {
            if (id < 0)
            {
                throw new Exception("Student Id can't be negative.");
            }
            this._id = id;
        }

        public int GetId()
        {
            return this._id;
        }

        public void SetName(String name)
        {
            if (String.IsNullOrEmpty(name))
            {
                throw new Exception("Name can't be null or empty.");
            }
            this._name = name;
        }

        public String GetName()
        {
            return String.IsNullOrEmpty(this._name) ? "No Name" : this._name;
        }

        public int GetPassMarks()
        {
            return this._passMarks;
        }

    }
    #endregion
    
}
