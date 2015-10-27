using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Part_038
{
    /// <summary>
    /// Part 037: Delegate usage continued....
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            #region 1.C Use delegate to de couple the logic of promoting the employee.
            List<Employee> empList = new List<Employee>();
            empList.Add(new Employee() { ID = 101, Name = "Anand", Salary = 4000, Experience = 3 });
            empList.Add(new Employee() { ID = 102, Name = "Praveen", Salary = 5000, Experience = 5 });
            empList.Add(new Employee() { ID = 103, Name = "Anoop", Salary = 6000, Experience = 4 });
            empList.Add(new Employee() { ID = 104, Name = "Uttam", Salary = 8000, Experience = 9 });

            IsPromotable isProtable = new IsPromotable(Promote);

            Employee.PromoteEmployee(empList, isProtable);

            #endregion

            #region 2.B Use delegate and lamda expression while calling it.
            //// lamda expression is basically work on delegates. So we can remove the creating delegate object and creating the function.
            List<Customer> custList = new List<Customer>();
            custList.Add(new Customer() { Name = "Ryan Lim", PurchaseAmount = 1000 });
            custList.Add(new Customer() { Name = "Jimmy Leong", PurchaseAmount = 20000 });
            custList.Add(new Customer() { Name = "Zech Lim", PurchaseAmount = 40000 });
            custList.Add(new Customer() { Name = "John read", PurchaseAmount = 6000 });

            // Here we are using lamda expression, for logic of valuable customer rather than creating a fucntion for delegate.
            Customer.IsValuableCustomer(custList, cust => cust.PurchaseAmount >= 10000);
            #endregion

            #region Example
            Voter v = new Voter();
            v.Age = 20;
            v.LetsVote(v, voter => voter.Age >= 18);

            Example_1 ex = new Example_1();
            ex.ExampleMethod();

            #endregion
            
            Console.ReadKey();

        }        
        #region 1.B Use delegate to de couple the logic of promoting the employee.
        /// <summary>
        /// This is the logic of promoting the employee, which will be decided by end user of class.
        /// </summary>
        /// <param name="paramEmp"></param>
        /// <returns></returns>
        public static bool Promote(Employee paramEmp)
        {
            if (paramEmp.Experience >= 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion        
    }

    #region 1.A. Use delegate to de couple the logic of promoting the employee.
    class Employee
    {
        public int ID { get; set; }
        public String Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }

        public static void PromoteEmployee(List<Employee> empList, IsPromotable isEligibleToPromote)
        {
            foreach (Employee emp in empList)
            {
                // We have removed hard coded logic from here. By using delegate.
                if (isEligibleToPromote(emp))
                {
                    Console.WriteLine(emp.Name + " - Promoted");
                }
            }
        }
    }
    delegate bool IsPromotable(Employee emp);
    #endregion

    #region 2.A Use delegate and lamda expression while calling it.
    class Customer
    {
        /*
         * If the customer purchase amount is greater than 1000, then it is valuable customer.
         */
        public String Name { get; set; }
        public int PurchaseAmount { get; set; }

        public static void IsValuableCustomer(List<Customer> custList, IsValuableCustomer isValuable)
        {
            foreach (Customer c in custList)
            {
                if (isValuable(c))
                {
                    Console.WriteLine(c.Name + " is valuable customer.");
                }
            }
        }
    }

    delegate bool IsValuableCustomer(Customer cust);

    #endregion
}
