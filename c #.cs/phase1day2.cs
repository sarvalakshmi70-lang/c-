using System;

class Program
{
    static void ShowSubjects(string[] subjects)
    {
        Console.WriteLine("Subjects:");

        foreach (string subject in subjects)
        {
            Console.WriteLine(subject);
        }
    }

    static void Main()
    {
        try
        {
            Console.Write("Enter Student Name: ");
            string studentName = Console.ReadLine();

            string[] subjects = { "C#", "SQL", "HTML", "CSS", "JavaScript" };

            ShowSubjects(subjects);

            Console.Write("Enter Student Mark: ");
            int mark = Convert.ToInt32(Console.ReadLine());

            if (mark >= 90)
            {
                Console.WriteLine("Grade: A");
            }
            else if (mark >= 75)
            {
                Console.WriteLine("Grade: B");
            }
            else if (mark >= 50)
            {
                Console.WriteLine("Grade: C");
            }
            else
            {
                Console.WriteLine("Grade: Fail");
            }

            Console.WriteLine("Countdown:");

            for (int i = 5; i >= 1; i--)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Student Name: " + studentName);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input");
        }
        finally
        {
            Console.WriteLine("sucessfully run the program");
        }
    }
}