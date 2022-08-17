using System;
class RefParameter
{
    // ref is Keyeword which is used for passing the value type by reference.
    static void Swap(ref int x, ref int y)
    {
        int z = x;
        x = y;
        y = z;
        Console.WriteLine(x+ " " +y);
    }
    static void Main252()
    {
        int num1 = 10;
        int num2 = 225;
        //By using ref Keyword 
        //if any changes made in this argument in  method will reflect in the variable-
        //when the control return to calling Method. 
        Swap(ref num1, ref num2);
        Console.WriteLine(num1+" " +num2);
      
    }
}