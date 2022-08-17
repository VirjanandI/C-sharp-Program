using System;
class NamesParameter
{
    static void Display(int empNo, string empName, double empSal)
    {
        Console.WriteLine(empNo);
        Console.WriteLine(empName);
        Console.WriteLine(empSal);
    }
    static void Main52()
    {
        Display(empNo: 1001, empName: "Sanjeev", empSal: 25000.25);
    }
}