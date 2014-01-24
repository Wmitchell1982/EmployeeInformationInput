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
            this.components = new System.ComponentModel.Container();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.sstInfo = new System.Windows.Forms.StatusStrip();
            this.sslblInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblCurrentStudents = new System.Windows.Forms.Label();
            this.lblPotentialStudents = new System.Windows.Forms.Label();
            this.lblProgramApprovals = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbSalary = new System.Windows.Forms.TextBox();
            this.tbDepatment = new System.Windows.Forms.TextBox();
            this.tbCurrentStudents = new System.Windows.Forms.TextBox();
            this.tbPotentialStudents = new System.Windows.Forms.TextBox();
            this.tbProgramApprovals = new System.Windows.Forms.TextBox();
            this.errInfo = new System.Windows.Forms.ErrorProvider(this.components);
            this.ttInfo = new System.Windows.Forms.ToolTip(this.components);
            this.employeeListDataSet = new EmployeeInformationInputProgram.EmployeeListDataSet();
            this.eMPLOYEE_LISTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eMPLOYEE_LISTTableAdapter = new EmployeeInformationInputProgram.EmployeeListDataSetTableAdapters.EMPLOYEE_LISTTableAdapter();
            this.tableAdapterManager = new EmployeeInformationInputProgram.EmployeeListDataSetTableAdapters.TableAdapterManager();
            this.sstInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeListDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEE_LISTBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(15, 244);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "&Add Record";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(143, 244);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 23);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "&Reset Form";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(15, 273);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(100, 23);
            this.btnShow.TabIndex = 10;
            this.btnShow.Text = "&Show Database";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(143, 273);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 23);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // sstInfo
            // 
            this.sstInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sslblInfo});
            this.sstInfo.Location = new System.Drawing.Point(0, 313);
            this.sstInfo.Name = "sstInfo";
            this.sstInfo.Size = new System.Drawing.Size(281, 22);
            this.sstInfo.TabIndex = 4;
            this.sstInfo.Text = "statusStrip1";
            // 
            // sslblInfo
            // 
            this.sslblInfo.Name = "sslblInfo";
            this.sslblInfo.Size = new System.Drawing.Size(0, 17);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(12, 9);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 6;
            this.lblFirstName.Text = "First Name";
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(12, 52);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(62, 13);
            this.lblDepartment.TabIndex = 7;
            this.lblDepartment.Text = "Department";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(140, 11);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 8;
            this.lblLastName.Text = "Last Name";
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Location = new System.Drawing.Point(140, 52);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(36, 13);
            this.lblSalary.TabIndex = 9;
            this.lblSalary.Text = "Salary";
            // 
            // lblCurrentStudents
            // 
            this.lblCurrentStudents.AutoSize = true;
            this.lblCurrentStudents.Location = new System.Drawing.Point(12, 95);
            this.lblCurrentStudents.Name = "lblCurrentStudents";
            this.lblCurrentStudents.Size = new System.Drawing.Size(132, 13);
            this.lblCurrentStudents.TabIndex = 10;
            this.lblCurrentStudents.Text = "Current Students Assigned";
            // 
            // lblPotentialStudents
            // 
            this.lblPotentialStudents.AutoSize = true;
            this.lblPotentialStudents.Location = new System.Drawing.Point(12, 138);
            this.lblPotentialStudents.Name = "lblPotentialStudents";
            this.lblPotentialStudents.Size = new System.Drawing.Size(139, 13);
            this.lblPotentialStudents.TabIndex = 11;
            this.lblPotentialStudents.Text = "Potential Students Assigned";
            // 
            // lblProgramApprovals
            // 
            this.lblProgramApprovals.AutoSize = true;
            this.lblProgramApprovals.Location = new System.Drawing.Point(12, 181);
            this.lblProgramApprovals.Name = "lblProgramApprovals";
            this.lblProgramApprovals.Size = new System.Drawing.Size(189, 13);
            this.lblProgramApprovals.TabIndex = 12;
            this.lblProgramApprovals.Text = "Current Number of Programs Approved";
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(143, 27);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(100, 20);
            this.tbLastName.TabIndex = 2;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(15, 27);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(100, 20);
            this.tbFirstName.TabIndex = 1;
            // 
            // tbSalary
            // 
            this.tbSalary.Location = new System.Drawing.Point(143, 70);
            this.tbSalary.Name = "tbSalary";
            this.tbSalary.Size = new System.Drawing.Size(100, 20);
            this.tbSalary.TabIndex = 4;
            // 
            // tbDepatment
            // 
            this.tbDepatment.Location = new System.Drawing.Point(15, 70);
            this.tbDepatment.Name = "tbDepatment";
            this.tbDepatment.Size = new System.Drawing.Size(100, 20);
            this.tbDepatment.TabIndex = 3;
            // 
            // tbCurrentStudents
            // 
            this.tbCurrentStudents.Location = new System.Drawing.Point(15, 113);
            this.tbCurrentStudents.Name = "tbCurrentStudents";
            this.tbCurrentStudents.Size = new System.Drawing.Size(100, 20);
            this.tbCurrentStudents.TabIndex = 5;
            // 
            // tbPotentialStudents
            // 
            this.tbPotentialStudents.Location = new System.Drawing.Point(15, 156);
            this.tbPotentialStudents.Name = "tbPotentialStudents";
            this.tbPotentialStudents.Size = new System.Drawing.Size(100, 20);
            this.tbPotentialStudents.TabIndex = 6;
            // 
            // tbProgramApprovals
            // 
            this.tbProgramApprovals.Location = new System.Drawing.Point(15, 199);
            this.tbProgramApprovals.Name = "tbProgramApprovals";
            this.tbProgramApprovals.Size = new System.Drawing.Size(100, 20);
            this.tbProgramApprovals.TabIndex = 7;
            // 
            // errInfo
            // 
            this.errInfo.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errInfo.ContainerControl = this;
            // 
            // ttInfo
            // 
            this.ttInfo.IsBalloon = true;
            // 
            // employeeListDataSet
            // 
            this.employeeListDataSet.DataSetName = "EmployeeListDataSet";
            this.employeeListDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eMPLOYEE_LISTBindingSource
            // 
            this.eMPLOYEE_LISTBindingSource.DataMember = "EMPLOYEE_LIST";
            this.eMPLOYEE_LISTBindingSource.DataSource = this.employeeListDataSet;
            // 
            // eMPLOYEE_LISTTableAdapter
            // 
            this.eMPLOYEE_LISTTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EMPLOYEE_LISTTableAdapter = this.eMPLOYEE_LISTTableAdapter;
            this.tableAdapterManager.UpdateOrder = EmployeeInformationInputProgram.EmployeeListDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 335);
            this.Controls.Add(this.tbProgramApprovals);
            this.Controls.Add(this.tbPotentialStudents);
            this.Controls.Add(this.tbCurrentStudents);
            this.Controls.Add(this.tbDepatment);
            this.Controls.Add(this.tbSalary);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.lblProgramApprovals);
            this.Controls.Add(this.lblPotentialStudents);
            this.Controls.Add(this.lblCurrentStudents);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.sstInfo);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnAdd);
            this.Name = "frmMain";
            this.Text = "Enter Employee Data";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.sstInfo.ResumeLayout(false);
            this.sstInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeListDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEE_LISTBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.StatusStrip sstInfo;
        private System.Windows.Forms.ToolStripStatusLabel sslblInfo;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label lblCurrentStudents;
        private System.Windows.Forms.Label lblPotentialStudents;
        private System.Windows.Forms.Label lblProgramApprovals;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbSalary;
        private System.Windows.Forms.TextBox tbDepatment;
        private System.Windows.Forms.TextBox tbCurrentStudents;
        private System.Windows.Forms.TextBox tbPotentialStudents;
        private System.Windows.Forms.TextBox tbProgramApprovals;
        private System.Windows.Forms.ErrorProvider errInfo;
        private System.Windows.Forms.ToolTip ttInfo;
        private System.Windows.Forms.BindingSource eMPLOYEE_LISTBindingSource;
        private EmployeeListDataSet employeeListDataSet;
        private EmployeeListDataSetTableAdapters.EMPLOYEE_LISTTableAdapter eMPLOYEE_LISTTableAdapter;
        private EmployeeListDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}

