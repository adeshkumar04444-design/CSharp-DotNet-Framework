using System;

class InParameter
{
    static void Main()
    {
        int number = 100;

        // 'in' passes the variable by reference
        // but prevents the method from modifying it.

        Display(in number);
    }

    static void Display(in int number)
    {
        Console.WriteLine("Number: " + number);

        // The following would NOT be allowed:
        // number = 200;
    }
}