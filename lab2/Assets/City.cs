public class City
{
    private string name;
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    private Dictionary<City, int> routes;
    public IReadOnlyDictionary<City, int> Routes { get { return routes; } }

    public City(string name)
    {
        routes = new();
        this.name = name;
    }

    public void AddRoute(City destination, int cost, bool isReverse = false)
    {
        routes[destination] = cost;
        if (isReverse) destination.AddRoute(this, cost);
    }
    public override string ToString()
    {
        if (routes.Count == 0) return $"{Name} (нет путей)";

        var str = $"Город {Name} Пути:";

        foreach (City key in routes.Keys) str += $" {key.Name}:{routes[key]}";

        return str;
    }
}