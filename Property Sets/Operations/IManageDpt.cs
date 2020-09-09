using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Property_Sets.Operations
{
    /// <summary>
    /// Interface for the department operations
    /// </summary>
    public interface IManageDpt
    {
        // This methood adds a new department
        public void AddDepartment(string department);

        // This method gets the list of all the departments
        public List<Department> GetDepartments();

        // This method gets the list of all the empty departments
        public IEnumerable GetEmptyDep();
    }
    
}
