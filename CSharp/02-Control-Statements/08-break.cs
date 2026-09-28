using System;

class BreakExample
{
    static void Main()
    {
        // break is used to immediately terminate
        // the loop or switch statement.

        for (int i = 1; i <= 10; i++)
        {
            if (i == 6)
            {
                // When i becomes 6,
                // the loop terminates immediately.
                break;
            }

            Console.WriteLine(i);
        }

        // Output:
        // 1
        // 2
        // 3
        // 4
        // 5
    }
}