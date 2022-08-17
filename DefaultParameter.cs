using System;
class DefaultParameter
{
    static string Cal(int x, int y, string choice= "-" )
    {
        string result = " ";
        if (choice == "+")
            result = Convert.ToString(x + y);
        else if (choice == "-")
            result = Convert.ToString(x - y);
        else if (choice == "*")
            result = Convert.ToString(x * y);
        else if (choice == "/")
            result = Convert.ToString(x / y);
        else
            result = "Invalid Operator";
        
        return result;
    }
  
    static void Main588()
    {
        Console.WriteLine(Cal(1,4));
    }
}