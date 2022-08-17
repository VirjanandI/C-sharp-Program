using System;
class OutParameter
{
    static void Cal(int x, int y, out int sum, out int minus, out float mul, out float div)
    {
        sum = x + y;
        minus = x - y;
        mul = x * y;
        div = x / y;

    }
    static void Main525()
    {
        int sum, minus; 
        float mul, div;

        Cal(100, 2, out sum, out minus, out mul, out div);
        Console.WriteLine(sum);
        Console.WriteLine(minus);
        Console.WriteLine(mul);
        Console.WriteLine(div);
    }
}