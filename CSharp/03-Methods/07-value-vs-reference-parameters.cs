using System;

class ValueVsReference
{
    static void Main()
    {
        int number = 10;

        // By default, value types are passed by value.
        // A copy of the value is passed to the method.

        ChangeValue(number);

        // Original value remains unchanged.
        Console.WriteLine("Original value: " + number);
    }

    static void ChangeValue(int number)
    {
        number = 100;

        // Only the local copy is changed.
        Console.WriteLine("Inside method: " + number);
    }
}