﻿using Property_Sets;
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
        int id;
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
                    upBox.Items.Add(d.departmentName);
                    //department.SelectionStart = d.departmentId;
                }
            } else
            {
                MessageBox.Show("Department Name can not be empty");
            }

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Department> deList = Mad.GetDepartments();

            foreach (Department d in deList)
            {
                //department.DropDownStyle = ComboBoxStyle.DropDownList;
                department.Items.Add(d.departmentName);
                upBox.Items.Add(d.departmentName);
                //department.SelectionStart = d.departmentId;
            }

            var ret = Made.GetEmployees();
            data.DataSource = ret;
           // foreach (Employee q in )
        }

        private void addEmp_Click(object sender, EventArgs e)
        {
            int ids = department.SelectedIndex + 1;
            decimal wa = salp.Value;
            if (firstName.Text != "" && lastName.Text != "" && email.Text != "" && phone.Text != "")
            {
                Made.AddEmployee(firstName.Text, lastName.Text, email.Text, phone.Text, hire.Value, wa, ids);
                var ret = Made.GetEmployees();
                data.DataSource = ret;
                MessageBox.Show($"{firstName.Text} {lastName.Text} has been added succesfully");
                firstName.Text = "";
                lastName.Text = "";
                email.Text = "";
                phone.Text = "";
            }
            else
            {
                MessageBox.Show("Please fill all textboxes in Add Employee");
            }
        }

        private void selectRow(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
            data.CurrentRow.Selected = true;
            id = Convert.ToInt32(data.Rows[e.RowIndex].Cells["Id"].FormattedValue.ToString());
            updateFirst.Text = data.Rows[e.RowIndex].Cells["firstName"].FormattedValue.ToString();
            updateLast.Text = data.Rows[e.RowIndex].Cells["lastName"].FormattedValue.ToString();
            updateMail.Text = data.Rows[e.RowIndex].Cells["email"].FormattedValue.ToString();
            updatePhone.Text = data.Rows[e.RowIndex].Cells["phoneNumber"].FormattedValue.ToString();
            upDate.Value = Convert.ToDateTime(data.Rows[e.RowIndex].Cells["hireDate"].FormattedValue.ToString());
            upSale.Value = Convert.ToDecimal(data.Rows[e.RowIndex].Cells["salary"].FormattedValue.ToString());
            upBox.Text = data.Rows[e.RowIndex].Cells["departmentName"].FormattedValue.ToString();
            } catch(Exception ex)
            {
                MessageBox.Show("Readonly");
            }


        }

        private void updateEmp(object sender, EventArgs e)
        {
            int idd = department.SelectedIndex + 1;
            decimal was = upSale.Value;
            Made.Updatemployee(id, updateFirst.Text, updateLast.Text, updateMail.Text, updatePhone.Text, upDate.Value, was, upBox.Text);
            MessageBox.Show($"{updateFirst.Text} {updateLast.Text} has been updated succesfully");
            var ret = Made.GetEmployees();
            data.DataSource = ret;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            Made.DeleteEmployee(id);
            var ret = Made.GetEmployees();
            data.DataSource = ret;
            MessageBox.Show($"Employee has been removed succesfully");
        }

        private void DeptGroup_Click(object sender, EventArgs e)
        {
            var ret = Made.GetEmployeeDeps();
            data.DataSource = ret;
        }

        private void SalaryB_Click(object sender, EventArgs e)
        {
            var ret = Made.GetEmployeeSal();
            data.DataSource = ret;
        }

        private void EmpDep_Click(object sender, EventArgs e)
        {
            var ret = Mad.GetEmptyDep();
            data.DataSource = ret;
        }

        private void DiaplayDeps_Click(object sender, EventArgs e)
        {
            var ret = Made.GetEmployeeWit();
            data.DataSource = ret;
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            var ret = Made.GetEmployees();
            data.DataSource = ret;
        }
    }
}
