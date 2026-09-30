using System;

class ReferenceTypes
{
    static void Main()
    {
        // Another important category in CTS is Reference Types.
        //
        // Reference types store a reference to an object
        // rather than directly storing the object's data.
        //
        // Examples:
        // class
        // object
        // string
        // array
        // interface
        // delegate

        Student student = new Student();

        student.Name = "Rahul";
        student.Age = 21;

        Console.WriteLine(student.Name);
        Console.WriteLine(student.Age);
    }
}

class Student
{
    // These fields belong to a reference-type object.
    public string Name;
    public int Age;
}