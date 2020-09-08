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
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salp)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
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
            1000000,
            0,
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
            this.comboBox1.Location = new System.Drawing.Point(0, 26);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(198, 28);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Text = "Select Employee";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Location = new System.Drawing.Point(12, 440);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(446, 401);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Update Employee";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 853);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salp)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

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
    }
}

