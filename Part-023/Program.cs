using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Part_023
{
    /// <summary>
    /// Part 023: Polymorphism
    /// </summary>
    class Program
    {
        /* Polymorphism is one of the main pillars of OOPs.
         * Polymorphism enables you to invoke derived class method thru base class reference variable at run time.
         * In the base class, the method is declared as virtual and in the derived class we override the same method.
         * The virtual keyword indicates, the method can be overridden in any derived class.
         */
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[4];
            employees[0] = new Employee();
            employees[1] = new PartTimeEmployee();
            employees[2] = new FullTimeEmployee();
            employees[3] = new TemporaryEmployee();

            foreach (Employee  e in employees)
            {
                /*
                 * Here in employee array there are 4 different type of employee objects.
                 * No any child class have print full name method even then, 
                 * it can invoke parent class method using the parent class referance variable.
                 */
                e.PrintFullName();
            }

            Employee[] emp2 = new Employee[4];
            emp2[0] = new Employee();
            emp2[1] = new PartTimeEmployee();
            emp2[2] = new FullTimeEmployee();
            emp2[3] = new TemporaryEmployee();

            foreach (var item in emp2)
            {
                item.SalaryCycle();
            }

        }
    }

    public class Employee
    {
        public String firstName = "First Name";
        public String lastName = "Last name";

        public void PrintFullName()
        {
            Console.WriteLine(firstName + " " + lastName);
        }

        public virtual void SalaryCycle()
        {
            Console.WriteLine("Salary cycle :");
        }
    }

    public class PartTimeEmployee : Employee
    {
        /* Here our intension is not to hide the base class method but to override the base class method. 
        Thats why we are using override keyword rather than new keyword.         
         */
        public override void SalaryCycle()
        {
            Console.WriteLine("Salary cycle :" + "Part time");
        }
        
    }

    public class FullTimeEmployee : Employee
    {
        public override void SalaryCycle()
        {
            Console.WriteLine("Salary cycle :" + "Full time");
        }
    }

    public class TemporaryEmployee : Employee
    {
        /* If you don't provide override method implementation in derived class, it will automatically invoke the base class method.
         Here it will call base class method for TemporaryEmployee class.
         */

        //public override void SalaryCycle()
        //{
        //    Console.WriteLine("Salary cycle :" + "Temp");
        //}
    }
}
