using System;
using System.Reflection;

namespace Part_053
{
    /// <summary>
    /// Part 053 : Reflection
    /// </summary>
    class Program
    {
        /*
         * :: NOTE :: Assembly contains two parts, One is intermediat language and other is MetaData. And MetaData contains the information of types within that assembly.
         * 
         * 1. Reflection is the ablility of inspecting an assemblies metadata at runtime. 
         * 2. It is used to find all the types in an assembly and/or dynamicaly invoke mmethods in an assembly.
         * 
         * Uses of reflection:
         * 1. When you drag and drop a button on a windows form or an asp.net application . 
         *      The properties window uses reflection to show all the properties of the button class.
         *      Sp, reflection is sextensively used by IDE (Integrated development environment) or a UI designers.
         *      
         * 2. Late binding can be achived by using reflection. You can use reflection to dynamically create an instance of a type, 
         *      about which we don't have any information at compile time. So reflection enables you to use code that is not availabl at compile time.
         *      
         * 3. Consider an example where we have two alternate implementations of an interface. 
         *      You want to allow the user to pick one or the other using a config file with reflection.
         *      You can simply read the name of the class whose implementation you want to use from the config file.
         *      And instanciate an instance of that class. This  is another example for late binding using reflection.
         * 
         */
        static void Main(string[] args)
        {
            // There are two ways to get type of any class. First by using typerof keyword and passing class as parameter or use GetType() method on istance of class.
            // and second usgin GetType() static method of Type class.
            // Example :: 
            //  1. Type T = typeof(Customer);
            //    OR  Customer C1 = new Customer();
            //        Type T = C1.GetType();
            //  2. Type T = Type.GetType("Part_053.Customer");
            #region Type info using reflection

            Type T = Type.GetType("Part_053.Customer");

            Console.WriteLine("Full name of class = {0}", T.FullName);
            Console.WriteLine("Just name of class = {0}", T.Name);
            Console.WriteLine("Just name of namespace = {0}", T.Namespace);
            #endregion

            #region Fields info.
            Console.WriteLine("\nFileds info of class.");
            FieldInfo[] fields = T.GetFields();
            foreach (FieldInfo f in fields)
            {
                Console.WriteLine("Field = {0} && Name = {1}", f.ToString(), f.Name);
            }
            #endregion

            #region Properties info.
            Console.WriteLine("\nProperty information of class.");
            PropertyInfo[] properties = T.GetProperties();
            foreach (PropertyInfo prop in properties)
            {
                Console.WriteLine("Property Name = {0} && Attribute = {1} && Return Type = {2}", prop.Name, prop.Attributes, prop.PropertyType.Name);
            }
            #endregion

            #region Constructors info.
            Console.WriteLine("\nConstructo info of class.");
            ConstructorInfo[] constructors = T.GetConstructors();
            foreach (ConstructorInfo c in constructors)
            {
                Console.WriteLine("Constructor = {0}", c.ToString());
            }
            #endregion

            #region Methods info.
            Console.WriteLine("\nMethod info of class.");
            MethodInfo[] methods = T.GetMethods();
            foreach (MethodInfo m in methods)
            {
                Console.WriteLine("Return Type = {0} && Method Name  = {1}", m.ReturnType.Name, m.Name);
            }
            #endregion

            Console.ReadKey();
        }
    }

    public class Customer
    {
        #region 1. Fields
        private int _privateField; // This would be not shown in during reflection due to its protection level.
        public int sampleField;
        public String nameField;
        #endregion

        #region 2. Properties
        public int Id { get; set; }
        public String Name { get; set; }
        #endregion

        #region 3. Constructors
        public Customer(int iD, String name)
        {
            this.Id = iD;
            this.Name = name;
        }

        public Customer()
        {
            this.Id = -1;
            this.Name = String.Empty;
        }
        #endregion

        #region 4. Methods

        public void PrintId()
        {
            Console.WriteLine("ID = {0}", this.Id);
        }

        public void PrintName()
        {
            Console.WriteLine("Name = {0}", this.Name);
        }
        #endregion

    }
}
