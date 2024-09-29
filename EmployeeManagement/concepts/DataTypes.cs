public static class DataTypes {
    // Main Data Types in C#
    
    // Numbers
    static int age = 25; // 32 bits
    static long distance = 1000000000000000000; // 64 bits
    static float weight = 65.5f; // 32 bits
    static double salary = 1000.50; // 64 bits
    static decimal money = 100; // 128 bits

    // Boolean
    static bool isMarried = true;

    // Text
    static char character = 'A'; // 16 bits
    
    // Reference Types
    // Strings are immutable
    static string name = "Alirio Mieres";

    /* The object class type is the ultimate base class of all other types. 
    Every type in C# directly or indirectly derives from the object class type. */
    static object obj = new object();

    public static void PrintDataTypes() {
        Console.WriteLine("Data Types in C#");
        Console.WriteLine("-------------------------------------------------");
        Console.WriteLine("(int)      Age: " + age);
        Console.WriteLine("(long)     Distance: " + distance);
        Console.WriteLine("(float)    Weight: " + weight);
        Console.WriteLine("(double)   Salary: " + salary);
        Console.WriteLine("(decimal)  Money: " + money);
        Console.WriteLine("(bool)     Is Married: " + isMarried);
        Console.WriteLine("(char)     Character: " + character);
        Console.WriteLine("(string)   Name: " + name);
        Console.WriteLine("(object)   Object: " + obj);
        Console.WriteLine("-------------------------------------------------");
    }    

}