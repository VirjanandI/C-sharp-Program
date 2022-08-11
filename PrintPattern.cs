using System;
class PrintPattern
{
    static void Pattern()
    {
        int ctr = 1;
        while (ctr <= 3)
        {
            int ptr = 1;
            while (ptr <= ctr)
            {
                Console.Write("A");
                ptr++;
            }
            Console.WriteLine();
            ctr++;
        }
    }
    static void Main2()
    {
        Pattern();
    }

}