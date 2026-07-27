using System;

class Program
{
    static void Main()
    {
        // Variables
        string name = "Vimal";
        int age = 20;
        string department = "AI-DS";

        Console.WriteLine(name);
        Console.WriteLine(age);
        Console.WriteLine(department);

        // Data Types
        string studentName = "Gayathri";
        double fees = 50000.25;
        char grade = 'A';
        bool pass = true;

        Console.WriteLine(studentName);
        Console.WriteLine(fees);
        Console.WriteLine(grade);
        Console.WriteLine(pass);

        // Operators
        int a = 20;
        int b = 50;

        Console.WriteLine("Addition: " + (a + b));
        Console.WriteLine("Subtraction: " + (a - b));
        Console.WriteLine("Multiplication: " + (a * b));
        Console.WriteLine("Division: " + (a / b));
        Console.WriteLine("Modulus: " + (a % b));

        // Comparison Operators
        Console.WriteLine("a == b : " + (a == b));
        Console.WriteLine("a != b : " + (a != b));
        Console.WriteLine("a > b : " + (a > b));
        Console.WriteLine("a < b : " + (a < b));
        Console.WriteLine("a >= b : " + (a >= b));
        Console.WriteLine("a <= b : " + (a <= b));
        //logical operators
        bool c = true;
        bool d = false;

        Console.WriteLine(c && d);
        Console.WriteLine(c || d);
        Console.WriteLine(!c);
        //type conversion
        double value = 15.8;
        int result = (int)value;

        Console.WriteLine(result);
        //convert class
        string mark = "20";

        int output = Convert.ToInt32(mark);

        Console.WriteLine(output+10);

       
        //strings
        string myname = "Sarva";

        Console.WriteLine(myname.Length);
        Console.WriteLine(myname.ToUpper());
        Console.WriteLine(myname.ToLower());
        Console.WriteLine(myname.Contains("ar"));
        //input and output
        Console.Write("Enter college name: ");

        string collegeName = Console.ReadLine();

        Console.WriteLine("Welcome to college " + collegeName);
        
        Console.ReadKey();

    }
}