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
            result = -33;

        return result;
    }
    static void Main()
    {
        Console.WriteLine("Enter the number : ");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the number : ");
        int num2 = int.Parse(Console.ReadLine());

        int a = Calculation(num1, num2);
	
	if(a<0)
		Console.WriteLine("Invalid operator")
	else
		Console.WriteLine(a)
    }
}

