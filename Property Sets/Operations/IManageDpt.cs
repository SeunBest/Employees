using System;
using System.Collections.Generic;
using System.Text;

namespace Property_Sets.Operations
{
    public interface IManageDpt
    {
        public void AddDepartment(string department);
        public List<Department> GetDepartments();
    }
    
}
