using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Property_Sets.Operations
{
    /// <summary>
    /// This interface mananges the employee operations
    /// </summary>
    public interface IManageEmp
    {
        // This method adds a new employee
        public void AddEmployee(string first, string last, string mail, string phone, DateTime date, decimal wage, int id);

        // This method updates an employee
        public IEnumerable GetEmployees();

        // This method gets all employees
        public void Updatemployee(int ids, string first, string last, string mail, string phone, DateTime date, decimal wage, string dept);

        // This method deletes an employee
        public void DeleteEmployee(int Id);

        //This method gets all the departments
        public IEnumerable GetEmployeeDeps();

        // This method gets all employees with salaries > 150,000
        public IEnumerable GetEmployeeSal();

        // This method gets all employees with their departments
        public IEnumerable GetEmployeeWit();
    }
}

