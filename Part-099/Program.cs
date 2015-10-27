using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Part_099
{
    /// <summary>
    /// Part 99 : Lambda expression in c
    /// </summary>
    class Program
    {
        /*
         * 1. What is Lambda expression ?
         *      Anonymous methods and Lambda expressions are very similar. 
         *      Anonymous methods were introduced in C# 2 and Lambda expression in C# 3.
         *      
         * 2. To find am employee with id = 102, using anonymous method is as:
         *      Employee employee = listEmployees.Find(delegate(Employee emp) { return emp.ID == 102; });
         *      
         * 3. To find am employee with id = 102, using Lambda expression is as:
         *      Employee employee = listEmployees.Find(emp => emp.ID == 102);
         *      
         * 4. You can also explicitly specify the input type  but not required such as:
         *      Employee employee = listEmployees.Find((Employee emp) => emp.ID == 102);
         *      
         * 5. This expression ( => ) is lambda expression and read as GOESTO. Notice that with a Lambda expression you don't have to 
         *      use the delegate keyword explicitly and don't have to specify the inout parameter type explicitly. 
         *      The parameter type is inferred. Lambda expressions are more convenient to use than anonymous methods.
         *      Lambda expressions are particularly helpful for writing LINQ query expressions.
         *      
         * 6. In most of the cases lambda expression superseds anonymous methods. 
         *      To my knowlendge, the only time we prefer to use anonymous methods over lambda is,
         *      when we have to omit the parameter list when it's not used within the body.
         *      
         * 7. Anonymous methods allow the parameter list to be omitted entirely when it's not used within the body,
         *      where as with lambda expression this is not the case.
         *      
         *          For Example:
         *              Button1.Click += delegate
         *              { 
         *                      MessageBox.Show("Button clicked"); 
         *              };
         *              
         *          The above code can be rewritten using lambda expression as shown below. Notice that with lambda we cannot omit the parameter list.      
         *              Button1.Click += (bject sender, EventArgs e) =>
         *              {
         *                      MessageBox.Show("Button clicked"); 
         *              };
         */
        static void Main(string[] args)
        {
            List<Employee> listEmployees = new List<Employee>()
            {
                new Employee() { ID = 101, Name = "Anand Dev" },
                new Employee() { ID = 102, Name = "Uttam Kumar" },
                new Employee() { ID = 103, Name = "Praveen" }
            };

            Employee employeeLambda = listEmployees.Find(emp => emp.ID == 102);
            Console.WriteLine("Using Lambda expression - ID = {0}, Name = {1}", employeeLambda.ID, employeeLambda.Name);

            int aNamesCount = listEmployees.Count((Employee emp) => emp.Name.StartsWith("A"));
            Console.WriteLine("\nNumber of employees whose name starting with 'A' = {0}", aNamesCount);

            Console.ReadKey();

        }
    }

    class Employee
    {
        public int ID { get; set; }
        public String Name { get; set; }
    }
}
