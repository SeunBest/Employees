namespace Employees
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.salp = new System.Windows.Forms.NumericUpDown();
            this.addEmp = new System.Windows.Forms.Button();
            this.department = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.hire = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.AddDpt = new System.Windows.Forms.Button();
            this.aDpt = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.delDept = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.UpdateEmp = new System.Windows.Forms.Button();
            this.upBox = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.upSale = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.upDate = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.updateMail = new System.Windows.Forms.TextBox();
            this.updatePhone = new System.Windows.Forms.TextBox();
            this.updateLast = new System.Windows.Forms.TextBox();
            this.updateFirst = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deptId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data = new System.Windows.Forms.DataGridView();
            this.label15 = new System.Windows.Forms.Label();
            this.Delete = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salp)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upSale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.salp);
            this.groupBox1.Controls.Add(this.addEmp);
            this.groupBox1.Controls.Add(this.department);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.hire);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.phone);
            this.groupBox1.Controls.Add(this.email);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lastName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.firstName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 275);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Employee";
            // 
            // salp
            // 
            this.salp.Location = new System.Drawing.Point(242, 179);
            this.salp.Maximum = new decimal(new int[] {
            -1530494976,
            232830,
            0,
            0});
            this.salp.Name = "salp";
            this.salp.Size = new System.Drawing.Size(198, 27);
            this.salp.TabIndex = 3;
            // 
            // addEmp
            // 
            this.addEmp.Location = new System.Drawing.Point(241, 230);
            this.addEmp.Name = "addEmp";
            this.addEmp.Size = new System.Drawing.Size(198, 38);
            this.addEmp.TabIndex = 8;
            this.addEmp.Text = "Add Employee";
            this.addEmp.UseVisualStyleBackColor = true;
            this.addEmp.Click += new System.EventHandler(this.addEmp_Click);
            // 
            // department
            // 
            this.department.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.department.FormattingEnabled = true;
            this.department.Location = new System.Drawing.Point(7, 241);
            this.department.Name = "department";
            this.department.Size = new System.Drawing.Size(198, 28);
            this.department.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Department";
            // 
            // hire
            // 
            this.hire.Location = new System.Drawing.Point(0, 179);
            this.hire.Name = "hire";
            this.hire.Size = new System.Drawing.Size(205, 27);
            this.hire.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(241, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Salary";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Hire date";
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(241, 112);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(199, 27);
            this.phone.TabIndex = 1;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(7, 113);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(198, 27);
            this.email.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(241, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phone number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(241, 46);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(199, 27);
            this.lastName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Last name";
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(6, 46);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(199, 27);
            this.firstName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "First name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.AddDpt);
            this.groupBox2.Controls.Add(this.aDpt);
            this.groupBox2.Location = new System.Drawing.Point(12, 293);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(446, 61);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Department";
            // 
            // AddDpt
            // 
            this.AddDpt.Location = new System.Drawing.Point(242, 19);
            this.AddDpt.Name = "AddDpt";
            this.AddDpt.Size = new System.Drawing.Size(198, 34);
            this.AddDpt.TabIndex = 8;
            this.AddDpt.Text = "Add Department";
            this.AddDpt.UseVisualStyleBackColor = true;
            this.AddDpt.Click += new System.EventHandler(this.addDept);
            // 
            // aDpt
            // 
            this.aDpt.Location = new System.Drawing.Point(6, 26);
            this.aDpt.Name = "aDpt";
            this.aDpt.Size = new System.Drawing.Size(198, 27);
            this.aDpt.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.delDept);
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Location = new System.Drawing.Point(12, 360);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(446, 62);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Delete Employee";
            // 
            // delDept
            // 
            this.delDept.Location = new System.Drawing.Point(241, 20);
            this.delDept.Name = "delDept";
            this.delDept.Size = new System.Drawing.Size(198, 34);
            this.delDept.TabIndex = 8;
            this.delDept.Text = "Delete Employee";
            this.delDept.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(8, 28);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(198, 28);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Text = "Select Employee";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.UpdateEmp);
            this.groupBox4.Controls.Add(this.upBox);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.upSale);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.upDate);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.updateMail);
            this.groupBox4.Controls.Add(this.updatePhone);
            this.groupBox4.Controls.Add(this.updateLast);
            this.groupBox4.Controls.Add(this.updateFirst);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Location = new System.Drawing.Point(12, 453);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(446, 321);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Update Employee";
            // 
            // UpdateEmp
            // 
            this.UpdateEmp.Location = new System.Drawing.Point(240, 271);
            this.UpdateEmp.Name = "UpdateEmp";
            this.UpdateEmp.Size = new System.Drawing.Size(198, 34);
            this.UpdateEmp.TabIndex = 8;
            this.UpdateEmp.Text = "Update Employee";
            this.UpdateEmp.UseVisualStyleBackColor = true;
            this.UpdateEmp.Click += new System.EventHandler(this.updateEmp);
            // 
            // upBox
            // 
            this.upBox.FormattingEnabled = true;
            this.upBox.Location = new System.Drawing.Point(6, 277);
            this.upBox.Name = "upBox";
            this.upBox.Size = new System.Drawing.Size(198, 28);
            this.upBox.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 258);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 20);
            this.label14.TabIndex = 7;
            this.label14.Text = "Department";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(242, 182);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 20);
            this.label13.TabIndex = 5;
            this.label13.Text = "Salary";
            // 
            // upSale
            // 
            this.upSale.Location = new System.Drawing.Point(241, 205);
            this.upSale.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.upSale.Name = "upSale";
            this.upSale.Size = new System.Drawing.Size(198, 27);
            this.upSale.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 182);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 20);
            this.label12.TabIndex = 5;
            this.label12.Text = "Hire date";
            // 
            // upDate
            // 
            this.upDate.Location = new System.Drawing.Point(6, 205);
            this.upDate.Name = "upDate";
            this.upDate.Size = new System.Drawing.Size(198, 27);
            this.upDate.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(242, 113);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 20);
            this.label11.TabIndex = 3;
            this.label11.Text = "Phone number";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 113);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 20);
            this.label10.TabIndex = 2;
            this.label10.Text = "Email";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(242, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Last name";
            // 
            // updateMail
            // 
            this.updateMail.Location = new System.Drawing.Point(6, 136);
            this.updateMail.Name = "updateMail";
            this.updateMail.Size = new System.Drawing.Size(199, 27);
            this.updateMail.TabIndex = 1;
            // 
            // updatePhone
            // 
            this.updatePhone.Location = new System.Drawing.Point(240, 136);
            this.updatePhone.Name = "updatePhone";
            this.updatePhone.Size = new System.Drawing.Size(199, 27);
            this.updatePhone.TabIndex = 1;
            // 
            // updateLast
            // 
            this.updateLast.Location = new System.Drawing.Point(240, 56);
            this.updateLast.Name = "updateLast";
            this.updateLast.Size = new System.Drawing.Size(199, 27);
            this.updateLast.TabIndex = 1;
            // 
            // updateFirst
            // 
            this.updateFirst.Location = new System.Drawing.Point(7, 56);
            this.updateFirst.Name = "updateFirst";
            this.updateFirst.Size = new System.Drawing.Size(199, 27);
            this.updateFirst.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "First name";
            // 
            // Id
            // 
            this.Id.DataPropertyName = "employeeId";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Id.Visible = false;
            this.Id.Width = 125;
            // 
            // deptId
            // 
            this.deptId.DataPropertyName = "departmentId";
            this.deptId.HeaderText = "deptId";
            this.deptId.MinimumWidth = 6;
            this.deptId.Name = "deptId";
            this.deptId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.deptId.Visible = false;
            this.deptId.Width = 125;
            // 
            // data
            // 
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.deptId});
            this.data.Location = new System.Drawing.Point(536, 58);
            this.data.Name = "data";
            this.data.RowHeadersWidth = 51;
            this.data.Size = new System.Drawing.Size(738, 590);
            this.data.TabIndex = 4;
            this.data.Text = "dataGridView1";
            this.data.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.selectRow);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(843, 27);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(151, 28);
            this.label15.TabIndex = 5;
            this.label15.Text = "Display Screen";
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(536, 659);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(208, 29);
            this.Delete.TabIndex = 6;
            this.Delete.Text = "Delete Employee";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 786);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.data);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Database";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salp)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upSale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button addEmp;
        private System.Windows.Forms.ComboBox department;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker hire;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button AddDpt;
        private System.Windows.Forms.TextBox aDpt;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button delDept;
        private System.Windows.Forms.NumericUpDown salp;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox upBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown upSale;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker upDate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox updateMail;
        private System.Windows.Forms.TextBox updatePhone;
        private System.Windows.Forms.TextBox updateLast;
        private System.Windows.Forms.TextBox updateFirst;
        private System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.Button updateDept;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn deptId;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button UpdateEmp;
        private System.Windows.Forms.Button Delete;
    }
}

