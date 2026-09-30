using System;

// Parent class / Base class.
class Animal
{
    public void Eat()
    {
        Console.WriteLine("Animal is eating.");
    }
}

// Child class / Derived class.
//
// Dog inherits the accessible members of Animal.

class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("Dog is barking.");
    }
}

class Inheritance
{
    static void Main()
    {
        Dog dog = new Dog();

        // Eat() belongs to Animal.
        // Dog can use it because Dog inherits Animal.

        dog.Eat();

        // Bark() belongs to Dog itself.
        dog.Bark();
    }
}