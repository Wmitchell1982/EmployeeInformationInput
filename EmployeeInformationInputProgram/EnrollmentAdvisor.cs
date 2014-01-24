using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/********************************************************
 * Program: Employee Information Input Program Ver 2.0  *
 * Programmer: William Mitchell                         *
 * Date of last update: 01/23/2014                      *
 * Course: POS/409                                      *
 * Instructor: Dr. Brad Purdy                           *
 ********************************************************/
namespace EmployeeInformationInputProgram
{
    class EnrollmentAdvisor : Employee
    {
        //creates a class for enrollment advisors that inherets from employees
        //sets private variables and public properties

        private int _currentStudents;
        private int _potentialStudents;
        private int _programAuthorizations;


        public int currentStudents 
        {
            get { return _currentStudents; }
            set { _currentStudents = value; }
        }

        public int potentialStudents 
        {
            get { return _potentialStudents; }
            set { _potentialStudents = value; }
        }

        public int programAuthorizations
        {
            get { return _programAuthorizations; }
            set { _programAuthorizations = value; }
        }

        public void createAdvisor(DataTable table) 
        {
            table.Rows.Add(employeeId, firstName, lastName, department, salary,
                       currentStudents, potentialStudents, programAuthorizations);
        }
    }

}
