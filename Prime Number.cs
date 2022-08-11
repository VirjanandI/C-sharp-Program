class Demo
{
    static void  PrimeNumber(int num)
    {
        int count = 0;
        int i = 2;
        while(i<num/2)
        {
            if (num % i == 0)
            {
                System.Console.WriteLine("{0} is Not Prime", num);
                count++;
                break;
            }
            i++;
        }
        if (count == 0)
        {
            System.Console.WriteLine("{0} is Prime", num);
        }
      
    }
    static void Main()
    {
        System.Console.Write("Enter the number 1 : ");
        int num = int.Parse(System.Console.ReadLine());
        PrimeNumber(num);
    }
}