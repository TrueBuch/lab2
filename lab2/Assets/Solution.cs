public class Solution
{
    public void CitiesTask()
    {
        City A = new("A");
        City B = new("B");
        City C = new("C");
        City D = new("D");
        City E = new("E");
        City F = new("F");

        A.AddRoute(B, 5, true);
        A.AddRoute(F, 1);
        A.AddRoute(D, 6, true);

        B.AddRoute(C, 3, true);

        C.AddRoute(D, 4, true);

        D.AddRoute(E, 2, true);

        E.AddRoute(F, 2, true);

        F.AddRoute(B, 1);

        Console.WriteLine(A);
        Console.WriteLine(B);
        Console.WriteLine(C);
        Console.WriteLine(D);
        Console.WriteLine(E);
        Console.WriteLine(F);

    }

    public void PersonTask()
    {
        Person lev = new("Лев", 170);
        Person pushkin = new(new Name("Сергей", "Пушкин"), 168, lev);
        Person aleksandr = new("Александр", 167, pushkin);

        Console.WriteLine(lev);
        Console.WriteLine(pushkin);
        Console.WriteLine(aleksandr);
    }

    public void CatTask()
    {
        Cat cat = new("Барсик");
        Console.WriteLine(cat);
        cat.May();
        cat.May(3);
    }
}