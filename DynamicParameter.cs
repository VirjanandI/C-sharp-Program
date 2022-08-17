using System;
class DynamicParameter
{
    static void add(dynamic x, dynamic y)
    {
        Console.WriteLine(x+y);
    }
    static void Main1111()
    {
        add(22,3);
        add("Hello ", "World..!");
        add(2202.2255, 224555.365);
    }
}