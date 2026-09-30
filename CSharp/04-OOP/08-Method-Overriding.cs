using System;

class Animal
{
    // 'virtual' allows a derived class to provide
    // its own implementation of this method.

    public virtual void Sound()
    {
        Console.WriteLine("Animal makes a sound.");
    }
}

class Dog : Animal
{
    // 'override' replaces the inherited implementation
    // with a specialized implementation.

    public override void Sound()
    {
        Console.WriteLine("Dog barks.");
    }
}

class MethodOverriding
{
    static void Main()
    {
        Dog dog = new Dog();

        // The overridden method in Dog is executed.
        dog.Sound();
    }
}

/*
Key points:

virtual  -> Allows overriding in a derived class.
override -> Provides a new implementation in the derived class.

Method overriding is an important part of
runtime polymorphism.
*/