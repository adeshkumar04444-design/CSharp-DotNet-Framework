using System;

class ReturnValue
{
    static void Main()
    {
        // The method returns an integer value.
        int result = Add(10, 20);

        Console.WriteLine("Result: " + result);
    }

    // int before the method name means
    // this method returns an integer value.

    static int Add(int a, int b)
    {
        // return sends the result back to the caller.
        return a + b;
    }
}