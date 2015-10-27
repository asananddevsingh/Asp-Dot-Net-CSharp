using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Part_100
{
    /// <summary>
    /// Part 100 : Func delegate in c#
    /// </summary>
    class Program
    {
        /*
         * 1. What is Func<T,TResult> ?
         *      This is just a generic delegate. Depending on the requirement,
         *      The type parameters(T and TResult) can be replaced with the corresponding type arguments.
         *      
         * 2. For Eample ::
         *      Func<Employee, string> is a delegate that represents a function expecting Employee object as an input parameter 
         *      and return a string.
         *      
         * 3. Lambda expression can also be used to achieve the same thing.
         * 
         * 4. What is the difference between Func delegate and lambda expression?
         *      They're the same, just two different way to write the same thing. 
         *      The lambda syntex is newer, more concise and easy to write.
         *      
         * 5. What if I have to pass two or more input parameters?
         *      As of this date, there are 17 overloaded versions of Func, 
         *      which enables us to pass variable number and type of input parameter.
         *      In the example 3, Func<int, int, string> represents a function that expects 2 int input parameter
         *      and return a string.
         */
        static void Main(string[] args)
        {
            List<Employee> listEmployees = new List<Employee>()
            {
                new Employee() { ID = 101, Name = "Anand Dev" },
                new Employee() { ID = 102, Name = "Uttam Kumar" },
                new Employee() { ID = 103, Name = "Praveen" }
            };

            #region 1. Using Func delegate.

            Func<Employee, string> selector = employee => "Name = " + employee.Name;
            IEnumerable<string> names = listEmployees.Select(selector);

            foreach (string name in names)
            {
                Console.WriteLine("Using Func delegate, {0}", name);
            }

            #endregion

            #region 2. Using lambda expression.

            IEnumerable<string> names2 = listEmployees.Select(employee => "Name = " + employee.Name);
            foreach (string name in names2)
            {
                Console.WriteLine("Using lambda expression, {0}", name);
            }

            #endregion

            #region 3. Example of passing more than one parameters in Func delegate.
            
            Func<int, int, string> funcDelegate = (firstNum, secondNum) => "\nSum = " + (firstNum + secondNum);

            string result = funcDelegate(4, 8);
            Console.WriteLine(result);

            #endregion
            Console.ReadKey();
        }
    }

    class Employee
    {
        public int ID { get; set; }
        public String Name { get; set; }
    }
}
