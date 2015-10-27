using System;

using System.Reflection;

namespace Part_055
{
    /// <summary>
    /// Part 055 : Late binding using reflection
    /// </summary>
    class Program
    {
        /*
         * 1. Early binding - Working with class which is present at compile time.
         * 2. Late binding - Working with class which is NOT present at compile time but at runtime. It can be achieved by reflection.
         * 3. Even if you comment Customer class and build the project, it will build successfully. 
         *      Because reflection inspects assembly metadata at runtime. NOT at compile time.
         */
        static void Main(string[] args)
        {
            #region 1. Early binding - Working with class which is present at compile time.
            SampleEarlyBinding s1 = new SampleEarlyBinding();
            String fullName = s1.GetFullName("Anand Dev", "Singh");
            Console.WriteLine("Full name = {0}", fullName);
            #endregion

            // Even if you comment Customer class and build the project, it will build successfully.
            #region 2. Late binding - Working with class which is NOT present at compile time but at runtime.
            
            // This will give the executable assembly, meaning which is entry point for any project.
            Assembly executingAssembly = Assembly.GetExecutingAssembly();

            // This will give the type or class you want to work on.
            Type customerType = executingAssembly.GetType("Part_055.Customer");

            // This will give the instance of our type.
            object customerInstance = Activator.CreateInstance(customerType);

            // This will give the method of the type.
            MethodInfo getFullName = customerType.GetMethod("GetFullName");

            // This will create the parameters for the methods.
            String[] parameters = new String[2];
            parameters[0] = "Anand Dev";
            parameters[1] = "Singh";

            // "Invoke" method of MethodInfo class will call our method.
            String reflectionFullName = (String)getFullName.Invoke(customerInstance, parameters);

            Console.WriteLine("Late binding using reflection = {0}", reflectionFullName);

            #endregion

            Console.ReadKey();
        }
    }

    #region Working with class which is present at compile time is called early binding.
    public class SampleEarlyBinding
    {
        public string GetFullName(String firstName, String lastName)
        {
            return firstName + ", " + lastName;
        }
    }
    #endregion

    #region Working with class which is NOT present at compile time but present at runtime, is called late binding.
    // Even if you comment Customer class and build the project, it will build successfully.
    public class Customer
    {
        public string GetFullName(String firstName, String lastName)
        {
            return firstName + ", " + lastName;
        }
    }
    #endregion
}
