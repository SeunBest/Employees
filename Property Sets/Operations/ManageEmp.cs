using Microsoft.EntityFrameworkCore;
using Property_Sets.Operations;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Property_Sets
{
    /// <summary>
    /// This class has all the employee operations
    /// </summary>
    public class ManageEmp : IManageEmp
    {
        // This method adds a new employee
        public void AddEmployee(string first, string last, string mail, string phone, DateTime date, decimal wage, int id)
        {
            using (var context = new PersonContext())
            {
                var dep = context.Departments.Find(id);
                var emp = new Employee()
                {
                    firstName = first,
                    lastName = last,
                    email = mail,
                    phoneNumber = phone,
                    hireDate = date,
                    salary = wage,
                    department = dep
                };

                context.Employees.Add(emp);
                context.SaveChanges();
            }
        }
        
        // This method updates an employee
        public void Updatemployee(int ids, string first, string last, string mail, string phone, DateTime date, decimal wage, string dept)
        {
            using (var context = new PersonContext())
            {
                var dep = context.Departments.Where(s => s.departmentName == dept).FirstOrDefault();
                var emp = new Employee()
                {
                    employeeId = ids,
                    firstName = first,
                    lastName = last,
                    email = mail,
                    phoneNumber = phone,
                    hireDate = date,
                    salary = wage,
                    department = dep
                };

                context.Employees.Update(emp);
                context.SaveChanges();
            }
        }

        // This method gets all employees
        public IEnumerable GetEmployees()
        {
            using (var context = new PersonContext())
            {
                return context.Employees.Include(x => x.department).Select(e => new { e.employeeId, e.firstName, e.lastName, e.email, e.phoneNumber, e.hireDate, e.salary, e.department.departmentId, e.department.departmentName }).ToList();
            }
        }

        // This method deletes an employee
        public void DeleteEmployee(int Id)
        {
            using (var context = new PersonContext())
            {
                var employee = context.Employees.Where(e => e.employeeId == Id).FirstOrDefault();
                context.Employees.Remove(employee);
                context.SaveChanges();
            }
        }

        // This method gets all the departments
        public IEnumerable GetEmployeeDeps()
        {
            using (var context = new PersonContext())
            {
                return context.Employees.Include(x => x.department).Select(e => new { e.firstName, e.lastName, e.department.departmentName }).ToList();
            }
        }

        // This method gets all employees with salaries > 150,000
        public IEnumerable GetEmployeeSal()
        {
            using (var context = new PersonContext())
            {
                return context.Employees.Where(e => e.salary > 150000).Select(e => new { e.firstName, e.lastName, e.salary }).ToList();
            }
        }

        // This method gets all employees with their departments
        public IEnumerable GetEmployeeWit()
        {
            using (var context = new PersonContext())
            {
                return context.Employees.Select(s => new { s.firstName, s.lastName, s.department.departmentName }).ToList();
            }
        }
    }
}
