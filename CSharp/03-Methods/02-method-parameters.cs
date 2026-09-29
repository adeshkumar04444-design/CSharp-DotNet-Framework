using System;

class MethodParameters
{
    static void Main()
    {
        // Arguments are passed to the method
        // when we call it.

        Greet("Adesh");
        Greet("Rahul");
    }

    // name is called a parameter.
    // It receives the value passed during the method call.

    static void Greet(string name)
    {
        Console.WriteLine("Hello, " + name);
    }
}