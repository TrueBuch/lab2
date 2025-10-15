using System.Text;

public class Program
{
    public static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        Solution solution = new();
        while (true)
        {
            int number = Choice();

            switch(number)
            {
                case 1: solution.PersonTask(); break;
                case 2: solution.CitiesTask(); break;
                case 3: solution.CatTask(); break;
            }
        }

    }

    public static int Choice()
    {
        while (true)
        {
            if (int.TryParse("Enter the task number: ".Input(), out int result))
            {
                if (result > 0 && result <= 20)
                {
                    return result;
                }
            }
            Util.InvalidInput();
        }
    }
}