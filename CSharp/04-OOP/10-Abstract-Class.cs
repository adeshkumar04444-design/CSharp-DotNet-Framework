using System;

// An abstract class is a class that is designed
// to be used as a base class.

// An abstract class cannot be instantiated directly.

abstract class Shape
{
    // An abstract method has no body.
    // Derived classes must provide its implementation.

    public abstract void Draw();

    // An abstract class can also contain
    // normal methods with implementation.

    public void Display()
    {
        Console.WriteLine("This is a shape.");
    }
}

class Circle : Shape
{
    // The derived class must implement
    // the abstract Draw() method.

    public override void Draw()
    {
        Console.WriteLine("Drawing a circle.");
    }
}

class AbstractClass
{
    static void Main()
    {
        // This is NOT allowed:
        //
        // Shape shape = new Shape();

        // Create an object of the derived class instead.

        Circle circle = new Circle();

        circle.Display();
        circle.Draw();
    }
}