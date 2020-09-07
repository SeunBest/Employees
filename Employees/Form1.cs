using Property_Sets;
using Property_Sets.Operations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employees
{
    public partial class Form1 : Form
    {
        IManageDpt Mad;
        public Form1(IManageDpt mad)
        {
            InitializeComponent();
            Mad = mad;
        }

        private void addDept(object sender, EventArgs e)
        {
            var dept = new Department();
            dept.departmentName = aDpt.Text;
            if (dept.departmentName != "")
            {
                Mad.AddDepartment(dept);
                MessageBox.Show($"{dept.departmentName} department has been added succesfully");
            } else
            {
                MessageBox.Show("Department Name can not be empty");
            }

            
        }
    }
}
