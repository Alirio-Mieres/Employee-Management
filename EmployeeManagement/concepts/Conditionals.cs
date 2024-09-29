public static class Conditionals {
    // There are two types of conditionals in C#: if and switch

    public static void PrintConditionals() {
        // If conditional
        Console.WriteLine("Conditionals in C#");
        Console.WriteLine("-------------------------------------------------");
        int x = 5;
        if (x > 5) {
            Console.WriteLine("x is greater than 5");
        } else if (x < 5) {
            Console.WriteLine("x is less than 5");
        } else {
            Console.WriteLine("x is equal to 5");
        }

        // Switch conditional
        int y = 5;
        switch (y) {
            case 1:
                Console.WriteLine("y is 1");
                break;
            case 2:
                Console.WriteLine("y is 2");
                break;
            case 3:
                Console.WriteLine("y is 3");
                break;
            default:
                Console.WriteLine("y is not 1, 2, or 3");
                break;
        }
    }

    public static void PrintTernary() {
        // You can also use conditionals in expressions
        int x = 5;
        int y = 10;
        int max = x > y ? x : y; // 10
        Console.WriteLine("PrintTernary: " + max);
    }

    public static void PrintNullCoalescing() {
        // Null coalescing operator
        string ?x = null;
        string y = x ?? "Default Value"; // "Default Value"
        Console.WriteLine("PrintNullCoalescing: " + y);
        Console.WriteLine("-------------------------------------------------");
    }
}