using System;

class OutParameter
{
    static void Main()
    {
        int result;

        // out allows a method to return a value
        // through a parameter.

        Calculate(out result);

        Console.WriteLine("Result: " + result);
    }

    static void Calculate(out int result)
    {
        // An out parameter must be assigned
        // before the method returns.

        result = 50 + 50;
    }
}