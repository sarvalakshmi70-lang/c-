using System;

abstract class Animal
{
    public abstract void Sound();

    public void Eat()
    {
        Console.WriteLine("Animal is eating");
    }
}

interface IMovable
{
    void Move();
}

class Dog : Animal, IMovable
{
    public override void Sound()
    {
        Console.WriteLine("Dog says Bow Bow");
    }

    public void Move()
    {
        Console.WriteLine("Dog is moving");
    }
}

class Cat : Animal, IMovable
{
    public override void Sound()
    {
        Console.WriteLine("Cat says Meow");
    }

    public void Move()
    {
        Console.WriteLine("Cat is moving");
    }
}

class School
{
    public static string name = "ABC School";

    public static void ShowName()
    {
        Console.WriteLine("School Name: " + name);
    }
}

class Program
{
    static void Main()
    {
        Dog dog = new Dog();
        Cat cat = new Cat();

        Console.WriteLine("Dog:");
        dog.Sound();
        dog.Eat();
        dog.Move();

        Console.WriteLine();

        Console.WriteLine("Cat:");
        cat.Sound();
        cat.Eat();
        cat.Move();

        Console.WriteLine();

        Console.WriteLine("Static Member:");
        School.ShowName();
    }
}

