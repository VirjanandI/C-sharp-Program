using System;
class LeapYear
{
    int year;
    // Default Constructor...
    private LeapYear()
    {
        Console.Write("Please enter year you wants to check 22: ");
        int year = int.Parse(Console.ReadLine());

        if(year % 4 == 0)
            Console.WriteLine("{0} is Leap Year. ", year);
        else
            Console.WriteLine("{0} is Not Leap Year. ", year);
    }
    static void Main2222()
    {
        LeapYear Leap = new LeapYear();
    }
}
