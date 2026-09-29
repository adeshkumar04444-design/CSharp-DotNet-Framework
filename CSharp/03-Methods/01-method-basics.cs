using System;

class MethodBasics
{
    static void Main()
    {
        // A method is a block of code designed
        // to perform a specific task.

        // Calling the method
        SayHello();
        SayHello();
    }

    // This is a simple method.
    // void means the method does not return a value.

    static void SayHello()
    {
        Console.WriteLine("Hello, Adesh!");
    }
}