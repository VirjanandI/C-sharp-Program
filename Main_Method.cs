using System;
using EmployeeDetails;
using AddressDetails;

namespace HAS_A_Program
{
    class MainMethod
    {
        static void Main()
        {
            Console.WriteLine("---------------------Enter Employee Details---------------------");
            Employee employee = new Employee();

            Console.Write("Enter Employee No. : ");
            int empNo = int.Parse(Console.ReadLine());
            employee.SetEmpNo(empNo);

            Console.Write("Enter Employee Name : ");
            string empName = Console.ReadLine();
            employee.SetEmpName(empName);

            Console.Write("Enter Employee Salary : ");
            double empSal = double.Parse(Console.ReadLine());
            employee.SetEmpSal(empSal);
            Console.WriteLine();

            Console.WriteLine("---------------------Enter Address Details---------------------");

            address address = new address();

            Console.Write("Enter House No. : ");
            int houseNo = int.Parse(Console.ReadLine());
            address.SetHouseNo(houseNo);

            Console.Write("Enter House Name : ");
            string houseName = Console.ReadLine();
            address.SetHouseName(houseName);

            Console.Write("Enter PinCode : ");
            int pinCode = int.Parse(Console.ReadLine());
            address.SetPinCode(pinCode);

            employee.SetAddress(address);

            Console.WriteLine("---------------------Enter Employee Details are Shown below---------------------");
            Console.WriteLine("EmpNo is: " + employee.GetEmpNo());
            Console.WriteLine("EmpName is: " + employee.GetEmpName());
            Console.WriteLine("EmpSal is: " + employee.GetEmpSal());
            //--------------------------------------------------------------//
            Console.WriteLine("Address : ");
            Console.WriteLine("House No : " + address.GetHouseNo());
            Console.WriteLine("House Name : " + address.GetHouseName());
            Console.WriteLine("PinCode : " + address.GetPinCode());

        }
    }
}
