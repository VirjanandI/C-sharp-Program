using System;
class PrintTable
{
    int num;
    PrintTable()
    {
        Console.Write("Enten Number : ");
        num = int.Parse(Console.ReadLine());

        int i = 1;
        while (i <= 10)
        {
            Console.WriteLine("{0} * {1} = {2}", num, i, num*i);
            i++;
        }
    }
    static void Main7687()
    {
        PrintTable Table = new PrintTable();
    }
}