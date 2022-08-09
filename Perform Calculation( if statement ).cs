using System;
class PerformCalculation
{
    static int Calculation(int num1, int num2)
    {
        Console.WriteLine("Enter Operator : ");
        char op = Convert.ToChar(Console.ReadLine());

        int result = 0;
        if (op == '+')
            result = num1 + num2;
        else if (op == '-')
            result = num1 - num2;

        else if (op == '*')
            result = num1 * num2;

        else if (op == '/')
            result = num1 / num2;
        else
            result = 0;

        return result;
    }
    static void Main()
    {
        Console.WriteLine("Enter the number : ");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the number : ");
        int num2 = int.Parse(Console.ReadLine());

        Console.WriteLine(Calculation(num1, num2));
    }
}

