using System;
using System.Data.SqlTypes;

namespace Property_Sets
{
    public class Employee
    {
        public int employeeId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string phoneNumber{ get; set; }
        public DateTime hireDate { get; set; }
        public decimal salary { get; set; }

        public int? departmentId { get; set; }
        public Department department { get; set; }
    }
}
