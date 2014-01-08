using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeInformationInputProgram
{
    class EnrollmentAdvisor : Employee
    {
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
    }
}
