using System;
class Overloading
{
    // Overloading
    int Sum(int x, int y) 
    {
        return x + y;
    }
    int Sum(int x, int y, int z)
    {
        return x + y + z;
    }
    int Sum(int x, int y, int z, int a)
    {
        return x + y + z + a;
    }

 static void Main()
    {
        Console.Write("Enter the first number : x : ");
        int x = int.Parse(Console.ReadLine());

        Console.Write("Enter the first number : y : ");
        int y = int.Parse(Console.ReadLine());

        Console.Write("Enter the first number : z : ");
        int z = int.Parse(Console.ReadLine());

        Console.Write("Enter the first number : a : ");
        int a = int.Parse(Console.ReadLine());

        Overloading overload = new Overloading();

        Console.WriteLine("Sum of ( X + Y ) is "+overload.Sum(x , y));
        Console.WriteLine("Sum of ( X + Y + Z ) is "+overload.Sum(x, y, z));
        Console.WriteLine("Sum of ( X + Y + Z + A ) is "+overload.Sum(x, y, z, a));
    }
}