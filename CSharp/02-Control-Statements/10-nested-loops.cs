using System;

class NestedLoops
{
    static void Main()
    {
        // A nested loop means a loop inside another loop.

        // The outer loop controls the rows.
        for (int row = 1; row <= 5; row++)
        {
            // The inner loop controls the columns.
            for (int column = 1; column <= row; column++)
            {
                Console.Write("* ");
            }

            // Move to the next line after each row.
            Console.WriteLine();
        }

        // Output:
        // * 
        // * *
        // * * *
        // * * * *
        // * * * * *
    }
}