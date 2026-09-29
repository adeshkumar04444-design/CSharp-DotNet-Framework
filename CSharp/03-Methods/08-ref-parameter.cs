using System;

class RefParameter
{
    static void Main()
    {
        int number = 10;

        // ref allows the method to work with
        // the original variable instead of a copy.

        ChangeValue(ref number);

        Console.WriteLine("After method: " + number);
    }

    static void ChangeValue(ref int number)
    {
        // This changes the original variable.
        number = 100;
    }
}