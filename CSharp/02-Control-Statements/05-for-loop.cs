using System;

class ForLoop
{
    static void Main()
    {
        // A for loop is generally used when
        // we know how many times we want to repeat something.

        // Initialization ; Condition ; Increment

        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine("Count: " + i);
        }

        // Execution:
        // i = 1 → condition checked → code executes
        // i++  → i becomes 2
        // This continues until i <= 5 becomes false.
    }
}