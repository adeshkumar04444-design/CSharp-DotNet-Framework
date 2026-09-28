using System;

class SwitchExample
{
    static void Main()
    {
        int day = 3;

        // switch is useful when we want to compare
        // one value against multiple possible values.

        switch (day)
        {
            case 1:
                Console.WriteLine("Monday");
                break;

            case 2:
                Console.WriteLine("Tuesday");
                break;

            case 3:
                Console.WriteLine("Wednesday");
                break;

            case 4:
                Console.WriteLine("Thursday");
                break;

            case 5:
                Console.WriteLine("Friday");
                break;

            default:
                // default executes when none of the cases match.
                Console.WriteLine("Invalid day.");
                break;
        }
    }
}