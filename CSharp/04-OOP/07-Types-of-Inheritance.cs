using System;

// ==================================================
// 1. SINGLE INHERITANCE
// ==================================================

// One child class inherits from one parent class.

class Animal
{
    public void Eat()
    {
        Console.WriteLine("Animal eats.");
    }
}

class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("Dog barks.");
    }
}


// ==================================================
// 2. MULTILEVEL INHERITANCE
// ==================================================

// A class inherits from another derived class,
// creating a chain of inheritance.

class LivingThing
{
    public void Breathe()
    {
        Console.WriteLine("Living thing breathes.");
    }
}

class Human : LivingThing
{
    public void Walk()
    {
        Console.WriteLine("Human walks.");
    }
}

class Student : Human
{
    public void Study()
    {
        Console.WriteLine("Student studies.");
    }
}


// ==================================================
// 3. HIERARCHICAL INHERITANCE
// ==================================================

// Multiple child classes inherit from the same parent class.

class Vehicle
{
    public void Start()
    {
        Console.WriteLine("Vehicle started.");
    }
}

class Car : Vehicle
{
    public void Drive()
    {
        Console.WriteLine("Car is driving.");
    }
}

class Bike : Vehicle
{
    public void Ride()
    {
        Console.WriteLine("Bike is riding.");
    }
}


// ==================================================
// MAIN CLASS
// ==================================================

class TypesOfInheritance
{
    static void Main()
    {
        // Single inheritance
        Dog dog = new Dog();

        dog.Eat();
        dog.Bark();


        // Multilevel inheritance
        Student student = new Student();

        student.Breathe();
        student.Walk();
        student.Study();


        // Hierarchical inheritance
        Car car = new Car();
        Bike bike = new Bike();

        car.Start();
        car.Drive();

        bike.Start();
        bike.Ride();
    }
}

/*
Important:

C# does NOT support multiple inheritance of classes.

For example, this is not allowed:

class C : A, B
{
}

However, C# supports implementing multiple interfaces:

class C : IFirst, ISecond
{
}

This allows a class to follow multiple contracts.
*/