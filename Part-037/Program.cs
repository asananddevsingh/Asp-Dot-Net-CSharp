using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Part_037
{
    /// <summary>
    /// Part 037: Delegate usage.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> empList = new List<Employee>();
            empList.Add(new Employee() { ID = 101, Name = "Anand", Salary = 4000, Experience = 3 });
            empList.Add(new Employee() { ID = 102, Name = "Praveen", Salary = 5000, Experience = 5 });
            empList.Add(new Employee() { ID = 103, Name = "Anoop", Salary = 6000, Experience = 4 });
            empList.Add(new Employee() { ID = 104, Name = "Uttam", Salary = 8000, Experience = 9 });
            Employee.PromoteEmployee(empList);

            Console.ReadKey();

        }
    }

    class Employee
    {
        public int ID { get; set; }
        public String Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }

        /// <summary>
        /// Here we are promoting the employee having exp >= 5. In future if our promotion crateria changes then we need to modify this function.
        /// We will see the example of delegate in next part.
        /// </summary>
        /// <param name="empList"></param>
        public static void PromoteEmployee(List<Employee> empList)
        {
            foreach (Employee emp in empList)
            {
                if (emp.Experience >= 5)
                {
                    Console.WriteLine(emp.Name + " - Promoted");
                }
            }
        }
    }
}
