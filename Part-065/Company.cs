using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Part_065
{
    /*
     * Creating indexer for our custom class.
     */
    public class Employee
    {
        public int EmployeeId { get; set; }
        public String Name { get; set; }
        public String Gender { get; set; }
    }

    public class Company
    {
        private List<Employee> _listEmployee;

        public Company()
        {
            _listEmployee = new List<Employee>();
            _listEmployee.Add((new Employee() { EmployeeId = 1, Name = "Anand Dev", Gender = "Male" }));
            _listEmployee.Add((new Employee() { EmployeeId = 2, Name = "Nanhi Batra", Gender = "Female" }));
            _listEmployee.Add((new Employee() { EmployeeId = 3, Name = "Praveen", Gender = "Male" }));
            _listEmployee.Add((new Employee() { EmployeeId = 4, Name = "Suman", Gender = "Female" }));
            _listEmployee.Add((new Employee() { EmployeeId = 5, Name = "Uttam", Gender = "Male" }));
        }

        #region Indexer
        public String this[int employeeId]
        {
            get
            {
                return _listEmployee.FirstOrDefault(emp => emp.EmployeeId == employeeId).Name;
            }
            set
            {
                _listEmployee.FirstOrDefault(emp => emp.EmployeeId == employeeId).Name = value;
            }
        } 
        #endregion
    }
}