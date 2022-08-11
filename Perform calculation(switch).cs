using System;
class PerformCalculation1
{
    static int Calculation1(int num1, int num2)
    {
        Console.WriteLine("Enter Operator + : ");
        char op = Convert.ToChar(Console.ReadLine());

        int result = 0;
        switch (op)
        {
            case '+':
                result = num1 + num2;
                break;

            case '-':
                result = num1 - num2;
                break;

            case '*':
                result = num1 * num2;
                break;

            case '/':
                result = num1 / num2;
                break;

            default:
                result = 0;
                break;
        }
        return result;
    }
    static void Main1()
    {
        Console.WriteLine("Enter the number : ");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the number : ");
        int num2 = int.Parse(Console.ReadLine());

        Console.WriteLine(Calculation1(num1, num2));
    }
}

