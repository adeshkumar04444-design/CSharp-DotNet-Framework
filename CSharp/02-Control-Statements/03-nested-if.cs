using System;

class NestedIf
{
    static void Main()
    {
        int age = 21;
        bool hasId = true;

        // A nested if means an if statement
        // inside another if statement.

        if (age >= 18)
        {
            Console.WriteLine("Age requirement satisfied.");

            if (hasId)
            {
                // This condition is checked only if
                // the outer condition is true.
                Console.WriteLine("ID verification successful.");
            }
            else
            {
                Console.WriteLine("ID is required.");
            }
        }
        else
        {
            Console.WriteLine("Age requirement not satisfied.");
        }
    }
}