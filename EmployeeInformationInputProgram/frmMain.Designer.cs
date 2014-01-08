namespace EmployeeInformationInputProgram
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblEmployeeId = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblCurrentStudents = new System.Windows.Forms.Label();
            this.lblPotentialStudents = new System.Windows.Forms.Label();
            this.lblProgramApprovals = new System.Windows.Forms.Label();
            this.tbEmployeeId = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbSalary = new System.Windows.Forms.TextBox();
            this.tbDepatment = new System.Windows.Forms.TextBox();
            this.tbCurrentStudents = new System.Windows.Forms.TextBox();
            this.tbPotentialStudents = new System.Windows.Forms.TextBox();
            this.tbProgramApprovals = new System.Windows.Forms.TextBox();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(18, 302);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "&Add Record";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(146, 302);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 23);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "&Reset Form";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(18, 331);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(100, 23);
            this.btnShow.TabIndex = 10;
            this.btnShow.Text = "&Show Results";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(146, 331);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 23);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 367);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(271, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // lblEmployeeId
            // 
            this.lblEmployeeId.AutoSize = true;
            this.lblEmployeeId.Location = new System.Drawing.Point(15, 24);
            this.lblEmployeeId.Name = "lblEmployeeId";
            this.lblEmployeeId.Size = new System.Drawing.Size(67, 13);
            this.lblEmployeeId.TabIndex = 5;
            this.lblEmployeeId.Text = "Employee ID";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(15, 67);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 6;
            this.lblFirstName.Text = "First Name";
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(15, 110);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(62, 13);
            this.lblDepartment.TabIndex = 7;
            this.lblDepartment.Text = "Department";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(143, 69);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 8;
            this.lblLastName.Text = "Last Name";
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Location = new System.Drawing.Point(143, 110);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(36, 13);
            this.lblSalary.TabIndex = 9;
            this.lblSalary.Text = "Salary";
            // 
            // lblCurrentStudents
            // 
            this.lblCurrentStudents.AutoSize = true;
            this.lblCurrentStudents.Location = new System.Drawing.Point(15, 153);
            this.lblCurrentStudents.Name = "lblCurrentStudents";
            this.lblCurrentStudents.Size = new System.Drawing.Size(132, 13);
            this.lblCurrentStudents.TabIndex = 10;
            this.lblCurrentStudents.Text = "Current Students Assigned";
            // 
            // lblPotentialStudents
            // 
            this.lblPotentialStudents.AutoSize = true;
            this.lblPotentialStudents.Location = new System.Drawing.Point(15, 196);
            this.lblPotentialStudents.Name = "lblPotentialStudents";
            this.lblPotentialStudents.Size = new System.Drawing.Size(139, 13);
            this.lblPotentialStudents.TabIndex = 11;
            this.lblPotentialStudents.Text = "Potential Students Assigned";
            // 
            // lblProgramApprovals
            // 
            this.lblProgramApprovals.AutoSize = true;
            this.lblProgramApprovals.Location = new System.Drawing.Point(15, 239);
            this.lblProgramApprovals.Name = "lblProgramApprovals";
            this.lblProgramApprovals.Size = new System.Drawing.Size(189, 13);
            this.lblProgramApprovals.TabIndex = 12;
            this.lblProgramApprovals.Text = "Current Number of Programs Approved";
            // 
            // tbEmployeeId
            // 
            this.tbEmployeeId.Location = new System.Drawing.Point(18, 42);
            this.tbEmployeeId.Name = "tbEmployeeId";
            this.tbEmployeeId.Size = new System.Drawing.Size(100, 20);
            this.tbEmployeeId.TabIndex = 0;
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(146, 85);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(100, 20);
            this.tbLastName.TabIndex = 2;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(18, 85);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(100, 20);
            this.tbFirstName.TabIndex = 1;
            // 
            // tbSalary
            // 
            this.tbSalary.Location = new System.Drawing.Point(146, 128);
            this.tbSalary.Name = "tbSalary";
            this.tbSalary.Size = new System.Drawing.Size(100, 20);
            this.tbSalary.TabIndex = 4;
            // 
            // tbDepatment
            // 
            this.tbDepatment.Location = new System.Drawing.Point(18, 128);
            this.tbDepatment.Name = "tbDepatment";
            this.tbDepatment.Size = new System.Drawing.Size(100, 20);
            this.tbDepatment.TabIndex = 3;
            // 
            // tbCurrentStudents
            // 
            this.tbCurrentStudents.Location = new System.Drawing.Point(18, 171);
            this.tbCurrentStudents.Name = "tbCurrentStudents";
            this.tbCurrentStudents.Size = new System.Drawing.Size(100, 20);
            this.tbCurrentStudents.TabIndex = 5;
            // 
            // tbPotentialStudents
            // 
            this.tbPotentialStudents.Location = new System.Drawing.Point(18, 214);
            this.tbPotentialStudents.Name = "tbPotentialStudents";
            this.tbPotentialStudents.Size = new System.Drawing.Size(100, 20);
            this.tbPotentialStudents.TabIndex = 6;
            // 
            // tbProgramApprovals
            // 
            this.tbProgramApprovals.Location = new System.Drawing.Point(18, 257);
            this.tbProgramApprovals.Name = "tbProgramApprovals";
            this.tbProgramApprovals.Size = new System.Drawing.Size(100, 20);
            this.tbProgramApprovals.TabIndex = 7;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 389);
            this.Controls.Add(this.tbProgramApprovals);
            this.Controls.Add(this.tbPotentialStudents);
            this.Controls.Add(this.tbCurrentStudents);
            this.Controls.Add(this.tbDepatment);
            this.Controls.Add(this.tbSalary);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.tbEmployeeId);
            this.Controls.Add(this.lblProgramApprovals);
            this.Controls.Add(this.lblPotentialStudents);
            this.Controls.Add(this.lblCurrentStudents);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblEmployeeId);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnAdd);
            this.Name = "frmMain";
            this.Text = "Enter Employee Data";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label lblEmployeeId;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label lblCurrentStudents;
        private System.Windows.Forms.Label lblPotentialStudents;
        private System.Windows.Forms.Label lblProgramApprovals;
        private System.Windows.Forms.TextBox tbEmployeeId;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbSalary;
        private System.Windows.Forms.TextBox tbDepatment;
        private System.Windows.Forms.TextBox tbCurrentStudents;
        private System.Windows.Forms.TextBox tbPotentialStudents;
        private System.Windows.Forms.TextBox tbProgramApprovals;
    }
}

