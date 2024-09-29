/// <summary>
/// Provides functionality to display a menu and capture user selection.
/// </summary>
public static class Menu
{
    /// <summary>
    /// Displays a menu with the specified options and captures the user's selection.
    /// </summary>
    /// <param name="options">An array of strings representing the menu options.</param>
    /// <returns>The index of the selected option.</returns>
    public static int ShowMenu(string[] options)
    {
        int selection = 0;

        while (true)
        {
            Console.Clear();

            // Show the menu options
            for (int i = 0; i < options.Length; i++)
            {
                if (i == selection)
                {
                    Console.ForegroundColor = ConsoleColor.Green; // Highlight the selected option
                    Console.WriteLine("-> " + options[i]);
                    Console.ResetColor();
                }
                else
                {
                    Console.WriteLine("   " + options[i]); // Normal option
                }
            }

            // Capture the pressed key
            var key = Console.ReadKey(true).Key;

            // Move the selection with the arrow keys
            if (key == ConsoleKey.UpArrow)
            {
                selection = (selection == 0) ? options.Length - 1 : selection - 1;
            }
            else if (key == ConsoleKey.DownArrow)
            {
                selection = (selection == options.Length - 1) ? 0 : selection + 1;
            }
            else if (key == ConsoleKey.Enter)
            {
                return selection;  // Return the selected option
            }
        }
    }
}