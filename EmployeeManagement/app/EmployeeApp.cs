/// <summary>
/// Represents an application for managing employees.
/// </summary>
public class EmployeeApp
{
    // List of Employee objects
    private List<Employee> employees = new List<Employee>();

    // Menu options for the application
    string[] options = { "1- Add a new Employee", "2- Show All the Employees", "3- Edit a Employee", "4- Save it", "Return" };

    /// <summary>
    /// Initializes a new instance of the EmployeeApp class and loads employees from the file.
    /// </summary>
    public EmployeeApp()
    {
        string filePath = "employees.txt"; // File path for employee data
        LoadEmployeesFromFile(filePath); // Load existing employees from file
    }

    /// <summary>
    /// Runs the employee management program.
    /// </summary>
    public void RunEmployeeProgram()
    {
        while (true)
        {
            // Show the menu and get the selected option
            int selectedOption = Menu.ShowMenu(options);

            // Handle the selected option
            if (options[selectedOption] == "Return")
            {
                break; // Exit the program
            }
            else if (options[selectedOption] == "1- Add a new Employee")
            {
                AddEmployee(); // Add a new employee
            }
            else if (options[selectedOption] == "2- Show All the Employees")
            {
                ShowEmployees(); // Display all employees
            }
            else if (options[selectedOption] == "3- Edit a Employee")
            {
                EditEmployee(); // Edit an existing employee
            }
            else if (options[selectedOption] == "4- Save it")
            {
                SaveEmployeesToFile("employees.txt"); // Save employees to file
                Console.WriteLine("Employees saved successfully!");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }

        // Clear the console and display a farewell message
        Console.Clear();
        Console.WriteLine("Thanks for using the program!");
    }

    /// <summary>
    /// Adds a new employee to the list.
    /// </summary>
    private void AddEmployee()
    {
        Console.Clear();
        Console.WriteLine("Add a new Employee");
        Console.WriteLine("------------------");
        string name = NameValidation(); // Validate and get the employee's name
        int age = AgeValidation(); // Validate and get the employee's age

        Console.Write("Department: ");
        string department = Console.ReadLine() ?? string.Empty; // Get the employee's department

        double salary = SalaryValidation(); // Validate and get the employee's salary

        int id = employees.Count + 1; // Generate a new ID for the employee

        // Create a new Employee object and add it to the list
        Employee employee = new Employee(id, name, age, department, salary);
        employees.Add(employee);

        Console.WriteLine("Employee added successfully!");
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }

    /// <summary>
    /// Displays all employees in the list.
    /// </summary>
    private void ShowEmployees()
    {
        Console.Clear();
        Console.WriteLine("Employees List");
        Console.WriteLine("--------------");

        // Loop through and display each employee's details
        foreach (Employee employee in employees)
        {
            Console.WriteLine($"ID: {employee.Id}");
            Console.WriteLine($"Name: {employee.Name}");
            Console.WriteLine($"Age: {employee.Age}");
            Console.WriteLine($"Department: {employee.Department}");
            Console.WriteLine($"Salary: {employee.Salary}");
            Console.WriteLine();
        }

        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }

    /// <summary>
    /// Edits the details of an existing employee.
    /// </summary>
    private void EditEmployee()
    {
        Console.Clear();
        Console.WriteLine("Edit an Employee");
        Console.WriteLine("------------------");

        int id;
        // Loop to validate the ID input
        while (true)
        {
            Console.Write("Enter the ID: ");
            string input = Console.ReadLine();

            // Check if the input is empty
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("The ID cannot be empty. Please enter a valid ID.");
                continue; // Prompt for input again
            }

            // Try to convert the input to an integer
            if (int.TryParse(input, out id) && id > 0)
            {
                break; // Conversion was successful, exit the loop
            }
            else
            {
                Console.WriteLine("Invalid ID. Please enter a positive numeric ID.");
            }
        }

        // Find the employee by ID
        Employee employee = employees.Find(e => e.Id == id);

        // Check if the employee exists
        if (employee == null)
        {
            Console.WriteLine("Employee not found!");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            return;
        }

        // Validate input for the name
        string name = NameValidation();

        // Validate input for the age
        int age = AgeValidation();

        // Validate input for the department
        Console.Write("Department: ");
        string department = Console.ReadLine() ?? string.Empty;

        // Validate input for the salary
        double salary = SalaryValidation();

        // Update the employee's information
        employee.Name = name;
        employee.Age = age;
        employee.Department = department;
        employee.Salary = salary;

        Console.WriteLine("Employee edited successfully!");
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }

    /// <summary>
    /// Validates and returns the employee's name.
    /// </summary>
    /// <returns>The validated name.</returns>
    private string NameValidation()
    {
        string name;
        while (true)
        {
            Console.Write("Name: ");
            string nameInput = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(nameInput))
            {
                name = nameInput;
                break; // Name is valid
            }
            else
            {
                Console.WriteLine("Name cannot be empty. Please enter a valid name.");
            }
        }
        return name; // Return the valid name
    }

    /// <summary>
    /// Validates and returns the employee's salary.
    /// </summary>
    /// <returns>The validated salary.</returns>
    private double SalaryValidation()
    {
        double salary;
        while (true)
        {
            Console.Write("Salary: ");
            string salaryInput = Console.ReadLine();

            if (double.TryParse(salaryInput, out salary) && salary > 0)
            {
                break; // Conversion was successful and the salary is valid
            }
            else
            {
                Console.WriteLine("Invalid salary. Please enter a non-negative numeric salary.");
            }
        }
        return salary; // Return the valid salary
    }

    /// <summary>
    /// Validates and returns the employee's age.
    /// </summary>
    /// <returns>The validated age.</returns>
    private int AgeValidation()
    {
        int age;
        while (true)
        {
            Console.Write("Age: ");
            string ageInput = Console.ReadLine();

            if (int.TryParse(ageInput, out age) && age >= 18)
            {
                break; // Conversion was successful and the age is valid
            }
            else
            {
                Console.WriteLine("Invalid age. Please enter a positive numeric age.");
            }
        }
        return age; // Return the valid age
    }

    /// <summary>
    /// Saves the employee list to a specified file.
    /// </summary>
    /// <param name="filePath">The path to the file where employees will be saved.</param>
    private void SaveEmployeesToFile(string filePath)
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            // Write each employee's details to the file
            foreach (var employee in employees)
            {
                writer.WriteLine($"{employee.Id},{employee.Name},{employee.Age},{employee.Department},{employee.Salary}");
            }
        }
        Console.WriteLine("Employees saved successfully!");
    }

    /// <summary>
    /// Loads employees from a specified file into the list.
    /// </summary>
    /// <param name="filePath">The path to the file from which employees will be loaded.</param>
    private void LoadEmployeesFromFile(string filePath)
    {
        // Check if the file exists
        if (File.Exists(filePath))
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                // Read each line and create Employee objects
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 5 &&
                        int.TryParse(parts[0], out int id) &&
                        int.TryParse(parts[2], out int age) &&
                        double.TryParse(parts[4], out double salary))
                    {
                        string name = parts[1];
                        string department = parts[3];
                        Employee employee = new Employee(id, name, age, department, salary);
                        employees.Add(employee); // Add the employee to the list
                    }
                }
            }
            Console.WriteLine("Employees loaded successfully!");
        }
        else
        {
            Console.WriteLine("No employee data found. Starting with an empty list.");
        }
    }
}
