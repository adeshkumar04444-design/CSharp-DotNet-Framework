using System;

class Animal
{
    public virtual void Sound()
    {
        Console.WriteLine("Animal makes a sound.");
    }
}

class Dog : Animal
{
    public override void Sound()
    {
        Console.WriteLine("Dog barks.");
    }
}

class Cat : Animal
{
    public override void Sound()
    {
        Console.WriteLine("Cat meows.");
    }
}

class Polymorphism
{
    static void Main()
    {
        // Polymorphism means "many forms".

        // A base class reference can point to
        // an object of a derived class.

        Animal animal1 = new Dog();
        Animal animal2 = new Cat();

        // Although both variables have the type Animal,
        // the actual object determines which Sound()
        // method is executed.

        animal1.Sound();
        animal2.Sound();
    }
}

/*
Output:

Dog barks.
Cat meows.

This is called runtime polymorphism
or dynamic method dispatch.
*/