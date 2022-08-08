using System;
class Student
{
    int rollNo;

    //Constructor declare by Programmer.
    // So this is called Non-Argumented Constructor.
    public Student(int rollNo)
    {
        this.rollNo = rollNo;
    }

    public void Show()
    {
        Console.WriteLine("Student RollNo. is : "+rollNo);
    }
}
class Demo
{
    static void Main()
    {
        Console.Write("Enter rollNo. : ");
        int rollNo = int.Parse(Console.ReadLine());
        Student student = new Student(rollNo);
        student.Show();
    }
}