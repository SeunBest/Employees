﻿using Microsoft.EntityFrameworkCore;
using Property_Sets.Operations;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Property_Sets
{
    public class ManageEmp : IManageEmp
    {
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

        public IEnumerable GetEmployees()
        {
            using (var context = new PersonContext())
            {
                return context.Employees.Include(x => x.department).Select(e => new { e.employeeId, e.firstName, e.lastName, e.email, e.phoneNumber, e.hireDate, e.salary, e.department.departmentId, e.department.departmentName }).ToList();
            }
        }
    }
}
