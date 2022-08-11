using System;
class PerformCalculation
{
    int num1;
    int num2;
    char op;
    string result;

    PerformCalculation()
    {
        Console.WriteLine("Enter the Fist Number (Num1) : ");
        num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the Fist Number (Num2) : ");
        num2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter Operator (op) : ");
        op = char.Parse(Console.ReadLine());

        if(op == '+')
                result = Convert.ToString(num1 + num2);
        
        else if (op == '-')
            result = Convert.ToString(num1 - num2);

       else if (op == '*')
            result = Convert.ToString(num1 * num2);

       else if (op == '/')
            result = Convert.ToString(num1 / num2);
        else
            result = "Invalid Operator ";
              
      
    Console.WriteLine("Result is = " + result);
    }
    static void Main85563()
    {
        PerformCalculation calculation = new PerformCalculation();
    }
}