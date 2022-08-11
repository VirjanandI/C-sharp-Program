using System;
class PrintPattern
{
    PrintPattern()
    {
        int ctr = 0;
        while (ctr <= 3)
        {
            int ptr = 0;
            while (ptr <= ctr)
            {
                Console.Write("A");
                ptr++;
            }
            Console.WriteLine();
            ctr++;
        }
    }
    static void Main5454()
    {
        PrintPattern Pattern = new PrintPattern();
    }
}