using System;

class ElseIf
{
    static void Main()
    {
        int marks = 78;

        // else-if is used when we have multiple conditions
        // that need to be checked one after another.

        if (marks >= 90)
        {
            Console.WriteLine("Grade: A+");
        }
        else if (marks >= 80)
        {
            Console.WriteLine("Grade: A");
        }
        else if (marks >= 70)
        {
            Console.WriteLine("Grade: B");
        }
        else if (marks >= 60)
        {
            Console.WriteLine("Grade: C");
        }
        else
        {
            Console.WriteLine("Grade: F");
        }
    }
}