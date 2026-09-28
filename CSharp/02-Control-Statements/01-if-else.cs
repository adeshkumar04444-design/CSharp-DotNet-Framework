using System;

class IfElse
{
    static void Main()
    {
        int age = 21;

        // if statement is used to execute a block of code
        // only when a given condition is true.

        if (age >= 18)
        {
            Console.WriteLine("You are eligible to vote.");
        }
        else
        {
            // else executes when the if condition is false.
            Console.WriteLine("You are not eligible to vote.");
        }
    }
}