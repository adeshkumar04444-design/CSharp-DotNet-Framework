using System;

class OptionalParameters
{
    static void Main()
    {
        // The second parameter has a default value.
        // Therefore, we can omit it while calling the method.

        Greet("Adesh");

        // We can also provide our own value.
        Greet("Adesh", "Good Morning");
    }

    static void Greet(
        string name,
        string message = "Hello")
    {
        Console.WriteLine(message + ", " + name);
    }
}