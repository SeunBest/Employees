using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Property_Sets.Operations
{
    /// <summary>
    /// This class handles department operations 
    /// </summary>
    public class ManageDpt : IManageDpt
    {
        // This methood adds a new department
        public void AddDepartment(string department)
        {
            using (var context = new PersonContext())
            {
                var dept = new Department()
                {
                    departmentName = department
                };
                context.Departments.Add(dept);
                context.SaveChanges();
            }
        }

        // This method gets the list of all the departments
        public List<Department> GetDepartments()
        {
            using (var context = new PersonContext())
            {
                return context.Departments.ToList();
            }
        }

        // This method gets the list of all the empty departments
        public IEnumerable GetEmptyDep()
        {
            using (var context = new PersonContext())
            {
                List<string> allEmployees = context.Employees
                      .Where(q => !string.IsNullOrEmpty(q.department.departmentName))
                      .Select(r => r.department.departmentName)
                      .ToList();
                return context.Departments
                      .Where(d => !allEmployees.Contains(d.departmentName))
                      .Select(t => new { value = t.departmentName })
                      .ToList();
            }
        }
    }
}
