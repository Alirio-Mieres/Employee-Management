class Program
{
    static void Main()
    {
        // Menu options
        string[] options = { "1- Run Employee Program", "2- Show the concepts code", "Exit" };
        EmployeeApp EmployeeManagement = new EmployeeApp();

        // Call the menu
        while (true)
        {
            int selectedOption = Menu.ShowMenu(options);

            // Check the selected option
            if (options[selectedOption] == "Exit")
            {
                break; // Exit the program
            }
            else if (options[selectedOption] == "1- Run Employee Program")
            {

                EmployeeManagement.RunEmployeeProgram();
            }
            else if (options[selectedOption] == "2- Show the concepts code")
            {
                // Show the concepts code
                DataTypes.PrintDataTypes();
                Expressions.PrintExpressions();
                Conditionals.PrintConditionals();
                Conditionals.PrintTernary();
                Conditionals.PrintNullCoalescing();
                Loops.PrintLoops();
                // Structures
                Point p = new Point(10, 20);
                p.Display(); // Output: Point: (10, 20)
                // Union Example
                // Create an instance of the UnionExample structure
                UnionExample u = new UnionExample();

                // Assign an integer value to the IntValue field
                u.IntValue = 42;

                // Print the value of the FloatValue field interpreting the same memory space as a float
                // The output will be a float value representing the bits of 42 as a float
                Console.WriteLine(u.FloatValue); 

                // Print the value of the ByteValue field interpreting the same memory space as a byte
                // The output will be the value of the first byte of the binary representation of 42
                Console.WriteLine(u.ByteValue);  

                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
            else
            {
                Console.Clear();
                Console.WriteLine($"You selected: {options[selectedOption]}");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }

        // Final message
        Console.Clear();
        Console.WriteLine("Thanks for using the program!");
    }
}
