using System;
class Employee
{
    private int empNo;
    private string empName;
    private double empSal;

    public Employee(int empNo, string empName, double empSal)
    {
        this.empNo = empNo;
        this.empName = empName;
        this.empSal = empSal;
    }

    public int EmpNo
    {
        get
        {
            return empNo;
        }
    }
    public string EmpName
    {
        get
        {
            return empName;
        }
    }
    public double EmpSal
    {
        get
        {
            return empSal;
        }
    }

}
class Demo
{
    static void Main()
    {
        Console.Write("Enter Employee Number : ");
        int empNo = int.Parse(Console.ReadLine());

        Console.Write("Enter Employee Name : ");
        string empName = Console.ReadLine();

        Console.Write("Enter Employee Salary : ");
        double empSal = Convert.ToInt64(Console.ReadLine());


        Employee employee = new Employee(empNo, empName, empSal);

        Console.WriteLine("Employee Number is : " + employee.EmpNo);
        Console.WriteLine("Employee Name is : " + employee.EmpName);
        Console.WriteLine("Employee Salary is : " + employee.EmpSal);

    }
}