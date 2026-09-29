using System;

class InstanceMethod
{
    static void Main()
    {
        // An instance method belongs to an object.
        // Therefore, we need to create an object
        // before calling the method.

        InstanceMethod obj = new InstanceMethod();

        obj.SayHello();
    }

    void SayHello()
    {
        Console.WriteLine("Hello from instance method.");
    }
}