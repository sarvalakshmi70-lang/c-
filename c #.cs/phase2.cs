using System;

class Student
{
    private string name;
    private int mark;

    public Student(string studentName, int studentMark)
    {
        name = studentName;
        mark = studentMark;
    }

    public void Display()
    {
        Console.WriteLine("Student Name: " + name);
        Console.WriteLine("Student Mark: " + mark);
    }
}

class Program
{
    static void Main()
    {
        Student student = new Student("Sarva", 90);

        student.Display();
    }
}