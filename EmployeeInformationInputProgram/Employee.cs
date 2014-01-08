using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/********************************************************
 * Program: Employee Information Input Program Ver 1.0  *
 * Programmer: William Mitchell                         *
 * Date of last update: 01/08/2014                      *
 * Course: POS/409                                      *
 * Instructor: Dr. Brad Purdy                           *
 ********************************************************/
namespace EmployeeInformationInputProgram
{
    class Employee
    {
        //creates a class for employees
        //sets private variables and public properties

        private int _employeeId;
        private string _firstName;
        private string _lastName;
        private string _department;
        private decimal _salary;

        public int employeeId
        {
            get { return _employeeId; }
            set { _employeeId = value; }
        }

        public string firstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string lastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public string department
        {
            get { return _department; }
            set { _department = value; }
        }

        public decimal salary
        {
            get { return _salary; }
            set { _salary = value; }
        }

        
    }
}
