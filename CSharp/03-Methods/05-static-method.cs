using System;

class StaticMethod
{
    static void Main()
    {
        // A static method belongs to the class itself.
        // We can call it without creating an object.

        SayHello();
    }

    static void SayHello()
    {
        Console.WriteLine("Hello from static method.");
    }
}