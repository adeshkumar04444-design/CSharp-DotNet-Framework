using System;

class MethodOverloading
{
    static void Main()
    {
        // Method overloading allows multiple methods
        // to have the same name but different parameters.

        Console.WriteLine(Add(10, 20));

        Console.WriteLine(Add(10, 20, 30));

        Console.WriteLine(Add(10.5, 20.5));
    }

    // Two integer parameters
    static int Add(int a, int b)
    {
        return a + b;
    }

    // Three integer parameters
    static int Add(int a, int b, int c)
    {
        return a + b + c;
    }

    // Two double parameters
    static double Add(double a, double b)
    {
        return a + b;
    }
}