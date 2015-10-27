using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Part_098
{
    /// <summary>
    /// Part 98 : Anonymous methods in c
    /// </summary>
    class Program
    {
        /*
         * What is an anonymous method?
         *      In simple terms, anonymous method is a method without a name. Introduced in C#2.
         *      They provide us a way of creating delegate instances without having to write a separate method.
         *      
         * With anonymous Methods delegate parameters are optional.
         *      Example : Adding dynamic button in windows form and in its event handler passing deligate without parameters (sender and e).
         *      
         * This means the below code:
                    Button1.Click += delegate(object obj, EventArgs eventArgs)
                    {
                        MessageBox.Show("Button Clicked");
                    };

                can be rewritten as shown below
                    Button1.Click += delegate
                    {
                        MessageBox.Show("Button Clicked");
                    };
         */

        static void Main(string[] args)
        {
            List<Employee> listEmployees = new List<Employee>()
            {
                new Employee() { ID = 101, Name = "Anand Dev" },
                new Employee() { ID = 102, Name = "Uttam Kumar" },
                new Employee() { ID = 103, Name = "Praveen" }
            };

            #region 1. Using predicate
            // Using predicate - Step 2
            Predicate<Employee> empPredicate = new Predicate<Employee>(FindEmployee);

            // Using predicate - Step 3
            Employee employee = listEmployees.Find(empPredicate);
            Console.WriteLine("Using predicate - ID = {0}, Name = {1}", employee.ID, employee.Name); 
            #endregion

            #region 2. Using anonynous mehtod.


            Employee employeeAnonymous = listEmployees.Find(delegate(Employee emp)
            {
                return emp.ID == 102;
            });
            Console.WriteLine("\nUsing anonymous method - ID = {0}, Name = {1}", employeeAnonymous.ID, employeeAnonymous.Name); 
            
            #endregion
        }

        // Using predicate - Step 1
        public static bool FindEmployee(Employee emp)
        {
            return emp.ID == 101;
        }
    }

    

    class Employee
    {
        public int ID { get; set; }
        public String Name { get; set; }
    }
}
