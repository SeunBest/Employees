using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Property_Sets.Operations
{
    public class ManageDpt : IManageDpt
    {
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

        public List<Department> GetDepartments()
        {
            using (var context = new PersonContext())
            {
                return context.Departments.ToList();
                //context.SaveChanges();
            }
        }
    }
}
