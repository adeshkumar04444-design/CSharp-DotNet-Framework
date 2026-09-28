using System;

class DoWhileLoop
{
    static void Main()
    {
        int i = 1;

        // do-while executes the code first
        // and checks the condition afterwards.

        // Therefore, a do-while loop executes
        // at least once.

        do
        {
            Console.WriteLine("Count: " + i);

            i++;
        }
        while (i <= 5);
    }
}