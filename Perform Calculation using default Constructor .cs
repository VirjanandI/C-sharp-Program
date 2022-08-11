using System;
class PerformCalculation1
{
    int num1;
    int num2;
    char op;
    string result;

    PerformCalculation1()
    {
        Console.WriteLine("Enter the Fist Number (Num1) : ");
        num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the Fist Number (Num2) : ");
        num2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter Operator (op) : ");
        op = char.Parse(Console.ReadLine());

        switch (op)
        {
            case '+':
                result= Convert.ToString(num1 + num2);
                break;
            case '-':
                result = Convert.ToString(num1 - num2);
                break;
            case '*':
                result = Convert.ToString(num1 * num2);
                break;
            case '/':
                result = Convert.ToString(num1 / num2);
                break;
            default:
                result = "Invalid Operator ";
                break;
        }
        Console.WriteLine("Result is = "+result);
    }
    static void Main85563()
    {
        PerformCalculation1 calculation = new PerformCalculation1();
    }
}