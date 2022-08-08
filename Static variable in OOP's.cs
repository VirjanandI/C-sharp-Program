using System;
class Test
{
    int x;
    static int y; //here y is a static variable.

    public void Show()
    {
        x = x + 1; // Variable x having dynamically memory allocation.
        y = y + 1;// Variable y having static memory allocation.

        Console.WriteLine(x + " " + y);
    }
    class Demo
    {
        static void Main()
        {
            Test t1 = new Test();
            Test t2 = new Test();
            Test t3 = new Test();

            t1.Show();
            t2.Show();
            t3.Show();
        }
    }
}
