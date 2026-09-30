using System;

// An interface defines a contract that a class
// agrees to follow.

// It specifies what members should be provided,
// but does not represent a normal class object.

interface IAnimal
{
    void Sound();

    void Eat();
}

class Dog : IAnimal
{
    // The Dog class must implement
    // all required interface members.

    public void Sound()
    {
        Console.WriteLine("Dog barks.");
    }

    public void Eat()
    {
        Console.WriteLine("Dog eats.");
    }
}

class InterfaceExample
{
    static void Main()
    {
        Dog dog = new Dog();

        dog.Sound();
        dog.Eat();
    }
}

/*
Important:

A class can implement multiple interfaces.

Example:

class Smartphone : ICamera, IPhone
{
    // Implement members of both interfaces.
}

This is one way C# provides behavior similar
to multiple inheritance.
*/