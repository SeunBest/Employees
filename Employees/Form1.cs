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
        IManageEmp Made;
        public Form1(IManageDpt mad, IManageEmp made)
        {
            InitializeComponent();
            Mad = mad;
            Made = made;
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

        private void addEmp_Click(object sender, EventArgs e)
        {
            int ids = department.SelectedIndex + 1;
            decimal wa = salp.Value;
            if (firstName.Text != "" && lastName.Text != "" && email.Text != "" && phone.Text != "")
            {
                Made.AddEmployee(firstName.Text, lastName.Text, email.Text, phone.Text, hire.Value, wa, ids); ;
                MessageBox.Show($"{firstName.Text} {lastName.Text} has been added succesfully");
            }
            else
            {
                MessageBox.Show("Please fill all textboxes in Add Employee");
            }
        }
    }
}
