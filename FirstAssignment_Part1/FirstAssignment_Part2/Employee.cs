using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAssignment_Part2
{
    class Employee
    {
        string firstName;
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        string lastName;
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        string empId;
        public string EmpId
        {
            get { return empId; }
            set { empId = value; }
        }
        double hoursWorked;
        public double HoursWorked
        {
            get { return hoursWorked; }
            set { hoursWorked = value; }
        }
        double payRate;
        public double PayRate
        {
            get { return payRate; }
            set { payRate = value; }
        }
        public double computePay()
        {
            return hoursWorked * payRate;
        }
        public double computeOvertimePay()
        {
            if(hoursWorked > 40)
            {
                return (hoursWorked - 40) * 1.5 * payRate;
            }
            else
            {
                return 0;
            }
        }

    }
}
