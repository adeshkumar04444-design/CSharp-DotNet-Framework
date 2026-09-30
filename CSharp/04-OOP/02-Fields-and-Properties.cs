using System;

class Student
{
    // A field is a variable declared inside a class.
    // Fields are used to store the state/data of an object.

    private string name;

    // A property provides controlled access to a field.
    //
    // get -> reads the value.
    // set -> assigns a value.

    public string Name
    {
        get
        {
            return name;
        }

        set
        {
            name = value;
        }
    }

    // Auto-property.
    // C# automatically creates a hidden backing field for it.

    public int Age { get; set; }
}

class FieldsAndProperties
{
    static void Main()
    {
        Student student = new Student();

        // Setting property values.
        student.Name = "Adesh";
        student.Age = 21;

        // Getting property values.
        Console.WriteLine("Name: " + student.Name);
        Console.WriteLine("Age: " + student.Age);
    }
}