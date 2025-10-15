public static class Util
{
    public static string Input(this string str)
    {
        Console.Write(str);
        return Console.ReadLine();
    }

    public static int GetInt()
    {
        while (true)
        {
            var input = "Enter a number: ".Input();

            if (int.TryParse(input, out int result)) return result;

            InvalidInput();
        }
    }

    public static string[] GetStrings(this string str)
    {
        Console.Write(str);
        return Console.ReadLine().Split(' ');
    }

    public static void Print<T>(this T[] arr)
    {
        foreach (var i in arr)
            Console.Write($"{i} ");
        Console.WriteLine();
    }
    public static void InvalidInput() => Console.WriteLine("Invalid input. Try again"); 
}