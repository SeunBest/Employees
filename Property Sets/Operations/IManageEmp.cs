using System;
using System.Collections.Generic;
using System.Text;

namespace Property_Sets.Operations
{
    public interface IManageEmp
    {
        public void AddEmployee(string first, string last, string mail, string phone, DateTime date, decimal wage, int id);
        
    }
}

