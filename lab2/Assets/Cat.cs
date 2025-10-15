public class Cat
{
    private string name;
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public Cat(string name)
    {
        this.name = name;
    }

    public override string ToString()
    {
        return $"Кот: {Name}";
    }

    public void May(int count = 1)
    {
        string str = "";
        for (int i = 0; i < count; i++) str += " Мяу";

        Console.WriteLine($"{Name}:{str}!");
    }
}