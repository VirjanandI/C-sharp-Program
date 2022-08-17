using System;
class ParamsParameter
{
    static void Display(params int []arr)
    {
        foreach (int data in arr)
        {
            Console.WriteLine(data);
        }
    }
    static void Main()
    {
        Display();
        Display(1,2);
        Display(1, 2, 3);
        Display(1, 2, 3, 4);
    }
}