using System;

class WhileLoop
{
    static void Main()
    {
        int i = 1;

        // while loop checks the condition BEFORE
        // executing the loop body.

        while (i <= 5)
        {
            Console.WriteLine("Count: " + i);

            i++;
        }

        // If the condition is false initially,
        // the while loop may execute zero times.
    }
}