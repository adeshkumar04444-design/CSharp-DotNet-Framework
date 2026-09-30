using System;

class ExceptionHandling
{
    static void Main()
    {
        try
        {
            int a = 10;
            int b = 0;

            // This operation causes a DivideByZeroException.
            int result = a / b;

            Console.WriteLine(result);
        }
        catch (DivideByZeroException)
        {
            // CLR provides an exception-handling mechanism
            // that allows the program to handle runtime errors
            // instead of crashing unexpectedly.

            Console.WriteLine("Cannot divide a number by zero.");
        }
    }
}