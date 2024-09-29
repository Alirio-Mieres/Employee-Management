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
