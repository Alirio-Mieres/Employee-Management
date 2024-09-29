public class Classes
{
    public static void InstanceClasses()
    {
        // Class
        EmployeeTest employee = new()
        {
            Name = "John Doe",
            Age = 30,
            Department = "IT",
            Salary = 50000
        };

        // Class with constructor
        EmployeeWithConstructor employeeWithConstructor = new EmployeeWithConstructor("John Doe", 30, "IT", 50000);

        // Class with properties
        EmployeeWithProperties employeeWithProperties = new()
        {
            Name = "John Doe",
            Age = 30,
            Department = "IT",
            Salary = 50000
        };

        // Abstract class
        PersonTest person = new Student
        {
            Name = "John Doe",
            Age = 30,
            School = "ABC School"
        };
    }
}

public class EmployeeTest
{
    public string Name = string.Empty;
    public int Age;
    public string Department = string.Empty;
    public double Salary;
}

// Class with constructor
public class EmployeeWithConstructor
{
    public string Name;
    public int Age;
    public string Department;
    public double Salary;

    public EmployeeWithConstructor(string name, int age, string department, double salary)
    {
        Name = name;
        Age = age;
        Department = department;
        Salary = salary;
    }
}

// Class with properties
public class EmployeeWithProperties
{
    public required string Name { get; set; }
    public int Age { get; set; }
    public required string Department { get; set; }
    public double Salary { get; set; }
}

// Abstract class
public abstract class PersonTest
{
    public required string Name { get; set; }
    public int Age { get; set; }

    public abstract void PrintInfo();
}

// Inheritance
public class Student : PersonTest
{
    public required string School { get; set; }

    public override void PrintInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}, School: {School}");
    }
}
