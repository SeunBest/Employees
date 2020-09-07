using System;
using System.Collections.Generic;
using System.Text;

namespace Property_Sets.Operations
{
    public class ManageDpt : IManageDpt
    {
        public void AddDepartment(Department department)
        {
            using (var context = new PersonContext())
            {
                context.Departments.Add(department);
                context.SaveChanges();
            }
        }
    }
}
