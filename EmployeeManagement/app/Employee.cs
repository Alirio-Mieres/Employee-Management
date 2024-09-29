/// <summary>
/// Represents a person with a name and age.
/// </summary>
public abstract class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    /// <summary>
    /// Initializes a new instance of the Person class.
    /// </summary>
    /// <param name="name">The name of the person.</param>
    /// <param name="age">The age of the person.</param>
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
}

/// <summary>
/// Represents an employee, inheriting from the Person class.
/// </summary>
public class Employee : Person
{
    public int Id { get; set; }
    public string Department { get; set; }
    public double Salary { get; set; }

    /// <summary>
    /// Initializes a new instance of the Employee class.
    /// </summary>
    /// <param name="id">The ID of the employee.</param>
    /// <param name="name">The name of the employee.</param>
    /// <param name="age">The age of the employee.</param>
    /// <param name="department">The department of the employee.</param>
    /// <param name="salary">The salary of the employee.</param>
    public Employee(int id, string name, int age, string department,  double salary)
        : base(name, age)  // Call the base class constructor
    {
        Id = id;
        Department = department;
        Salary = salary;
    }
}
