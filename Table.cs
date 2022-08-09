using System;
class PrintTable
{
    static void Table(int num)
    {
        int i = 1;
        while (i <= 10)
        {
            Console.WriteLine("{0} * {1} = {2}", num,i, num*i);
            i++;
        }
    }
    static void Main1()
    {
        Console.WriteLine("Enter number : ");
        int num = int.Parse(Console.ReadLine());
        Table(num);
    }

}