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
            if (aDpt.Text != "")
            {
                Mad.AddDepartment(aDpt.Text);
                MessageBox.Show($"{aDpt.Text} department has been added succesfully");

                var deList = Mad.GetDepartments();

                department.Items.Clear();
                foreach (Department d in deList)
                {
                    //department.DropDownStyle = ComboBoxStyle.DropDownList;
                    department.Items.Add(d.departmentName);
                    //department.SelectionStart = d.departmentId;
                }
            } else
            {
                MessageBox.Show("Department Name can not be empty");
            }

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var deList = Mad.GetDepartments();

            foreach (Department d in deList)
            {
                //department.DropDownStyle = ComboBoxStyle.DropDownList;
                department.Items.Add(d.departmentName);
                //department.SelectionStart = d.departmentId;
            }
        }
    }
}
