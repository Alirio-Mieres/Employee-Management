public static class Expressions {

    public static void PrintExpressions() {
        // Arithmetic expressions
        int sum = 1 + 2; // 3
        int difference = 5 - 3; // 2
        int product = 2 * 3; // 6
        int quotient = 10 / 2; // 5

        // You can see the result in the console
        Console.WriteLine("Expressions in C#");
        Console.WriteLine("-------------------------------------------------");
        Console.WriteLine("Sum: " + sum);
        Console.WriteLine("Difference: " + difference);
        Console.WriteLine("Product: " + product);
        Console.WriteLine("Quotient: " + quotient);
        Console.WriteLine("-------------------------------------------------");
    }

    public static void PrintOtherExpressions() {
        // Other expressions
        // Assing expressions
        int a = 5;
        a += 2; // 7
        a -= 2; // 5
        a *= 2; // 10
        a /= 2; // 5

        // Comparison expressions
        bool isEqual = 5 == 5; // true
        bool isNotEqual = 5 != 5; // false
        bool isGreater = 5 > 5; // false
        bool isLess = 5 < 5; // false
        bool isGreaterOrEqual = 5 >= 5; // true
        bool isLessOrEqual = 5 <= 5; // true

        // Ternary expressions
        int x = 5;
        int y = 10;
        int max = x > y ? x : y; // 10


        Console.WriteLine("Other Expressions in C#");
        Console.WriteLine("-------------------------------------------------");
        Console.WriteLine("Assing expressions: " + a);
        Console.WriteLine("Comparison expressions: ");
        Console.WriteLine("Is Equal: " + isEqual);
        Console.WriteLine("Is Not Equal: " + isNotEqual);
        Console.WriteLine("Is Greater: " + isGreater);
        Console.WriteLine("Is Less: " + isLess);
        Console.WriteLine("Is Greater Or Equal: " + isGreaterOrEqual);
        Console.WriteLine("Is Less Or Equal: " + isLessOrEqual);
        Console.WriteLine("Ternary expressions: " + max);
    }
}