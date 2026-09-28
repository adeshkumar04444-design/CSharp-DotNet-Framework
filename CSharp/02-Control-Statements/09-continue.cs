using System;

class ContinueExample
{
    static void Main()
    {
        // continue skips the current iteration
        // and moves to the next iteration of the loop.

        for (int i = 1; i <= 5; i++)
        {
            if (i == 3)
            {
                // 3 will be skipped.
                continue;
            }

            Console.WriteLine(i);
        }

        // Output:
        // 1
        // 2
        // 4
        // 5
    }
}