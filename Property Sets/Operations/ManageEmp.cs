using System;
using System.Collections.Generic;
using System.Text;

namespace Property_Sets
{
    public class ManageEmp
    {
        public void AddEmployee(string first, string last, string mail, string phone, DateTime date, decimal wage, string dep)
        {
            using (var context = new PersonContext())
            {
                var emp = new Employee()
                {
                    firstName = first,
                    lastName = last,
                    email = mail,
                    phoneNumber = phone,
                    hireDate = date,
                    salary = wage, 
                };
                context.Employees.Add(emp);
                context.SaveChanges();
            }
        }
    }
}
