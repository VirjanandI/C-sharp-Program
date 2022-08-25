using System;
using AddressDetails;

namespace EmployeeDetails
{
    class Employee
    {
        private int empNo;
        private string empName;
        private double empSal;
        private Address address;

        public Employee(int empNo, string empName, double empSal, Address address)
        {
            this.empNo = empNo;
            this.empName = empName;
            this.empSal = empSal;
            this.address = address;
        }
        public int GetempNo()
        {
            return empNo;
        }
        public string GetempName()
        {
            return empName;
        }
        public double GetempSal()
        {
            return empSal;
        }
        public Address GetAddress()
        {
            return address;
        }
    }
}