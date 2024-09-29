public static class Loops
{
    // There are three types of loops in C#: for, while, do-while and foreach
    public static void PrintLoops()
    {
        // For loop
        Console.WriteLine("Loops in C#");
        Console.WriteLine("-------------------------------------------------");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("For loop: " + i);
        }

        // While loop
        int j = 0;
        while (j < 5)
        {
            Console.WriteLine("While loop: " + j);
            j++;
        }

        // Do-while loop
        int k = 0;
        do
        {
            Console.WriteLine("Do-while loop: " + k);
            k++;
        } while (k < 5);

        // Foreach loop
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

        foreach (int number in numbers)
        {
            Console.WriteLine("foreach loop: " + number);
        }
        Console.WriteLine("-------------------------------------------------");
    }

}