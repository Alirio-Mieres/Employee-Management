public static class Functions
{
    // In this case void means that the function does not return any value
    // static means that the function belongs to the class and not to an instance of the class
    public static void SayHello()
    {
        Console.WriteLine("Hello, World!");
    }

    // Method overloading 
    public static string SayHello(string name)
    {
        return $"Hello, {name}!";
    }

    // Function with return type
    public static int Sum(int a, int b)
    {
        return a + b;
    }

    // Function with multiple return values
    public static (int, int) GetMinMax(int[] numbers)
    {
        int min = numbers[0];
        int max = numbers[0];

        foreach (var number in numbers)
        {
            if (number < min)
            {
                min = number;
            }

            if (number > max)
            {
                max = number;
            }
        }

        return (min, max);
    }

    // lambda expression
    // Func<int, int, int> sum = (a, b) => a + b;


    // Asynchronous function
    public static async Task<int> GetDataAsync()
    {
        await Task.Delay(1000);
        return 42;
    }

}