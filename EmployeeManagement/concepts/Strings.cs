public static class Strings {
    // This is a string variable
    static string text = "Hello, World!";

    // String concatenation
    static string text2 = "Hello" + "World"; // "HelloWorld"

    // String interpolation
    static string text3 = $"Hello, {text}"; // "Hello, World!"

    // String length
    static int length = text.Length; // 13

    // String comparison
    static bool isEqual = text == "Hello, World!"; // true

    static string sub = text.Substring(0, 5); // "Hello"
    
    public static void PrintStringsMethodsResults() {
        Console.WriteLine("Strings in C#");
        Console.WriteLine("-------------------------------------------------");
        Console.WriteLine("Text: " + text);
        Console.WriteLine("Text2: " + text2);
        Console.WriteLine("Text3: " + text3);
        Console.WriteLine("Length: " + length);
        Console.WriteLine("Is Equal: " + isEqual);
        Console.WriteLine("Substring: " + sub);
        Console.WriteLine("-------------------------------------------------");
    }


}

