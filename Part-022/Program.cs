using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Part_022
{
    /// <summary>
    /// Part 022: Method hiding
    /// </summary>
    class Program
    {
        /// When you want to hide base class method, Use new keyword.
        /// 1st way, If you want to invoke base class hidden method, Use base.HiddenMethodName(). 
        /// 2nd way, If you want to invoke base class hidden method, Use base.HiddenMethodName().
        static void Main(string[] args)
        {
            FullTimeEmployee ft = new FullTimeEmployee();
            ft.firstName = "Anand";
            ft.lastName = "Dev";
            ft.PrintFullName();

            PartTimeEmployee pt = new PartTimeEmployee();
            pt.firstName = "Uttamm";
            pt.lastName = "Kumar";
            pt.PrintFullName();

            // 2nd way, If you want to invoke base class hidden method, Use base.HiddenMethodName().
            PartTimeEmployee pt2 = new PartTimeEmployee();
            pt2.firstName = "Praveen";
            pt2.lastName = "Shamra";
            ((Employee)pt2).PrintFullName();

            // 3rd way, If you want to invoke base class hidden method, Use base.HiddenMethodName().
            Employee e = new PartTimeEmployee();
            e.firstName = "Anoop";
            e.lastName = "Agarwal";
            e.PrintFullName();

            Console.ReadKey();
        }
    }

    public class Employee
    {
        public String firstName;
        public String lastName;

        public void PrintFullName()
        {
            Console.WriteLine(firstName +  " " + lastName);
        }
    }

    public class PartTimeEmployee : Employee
    {
        /// <summary>
        /// When you want to hide base class method, Use new keyword.
        /// </summary>
        public new void PrintFullName()
        {
            // 1st way, If you want to invoke base class hidden method, Use base.HiddenMethodName(). 
            base.PrintFullName();

            // This is specialization given to child class method. 
            Console.WriteLine(firstName + " " + lastName + " - Contractor");
        }
    }

    public class FullTimeEmployee : Employee
    {

    }
}
