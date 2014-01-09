using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/********************************************************
 * Program: Employee Information Input Program Ver 1.1 *
 * Programmer: William Mitchell                         *
 * Date of last update: 01/08/2014                      *
 * Course: POS/409                                      *
 * Instructor: Dr. Brad Purdy                           *
 ********************************************************/
namespace EmployeeInformationInputProgram
{
    public partial class frmResults : Form
    {
        //form to display results of added records

        public DataTable employeeList { get; set; } //creates a DataTable property to be used to get the data table from the main form

        public frmResults()
        {
            InitializeComponent();
        }

        //closes the form
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //populates the datagrid on load
        private void frmResults_Load(object sender, EventArgs e)
        {

            this.dgResults.DataSource = employeeList;
            this.dgResults.Columns["Salary"].DefaultCellStyle.Format = "C"; //sets currency format for salary column
              
        }

        


    }
}
