public class Person
{
    private Name name;
    private int height;
    private Person father;

    public Name Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Height
    {
        get { return height; }
        set
        {
            int temp = value;
            while (temp <= 0)
            {
                Util.InvalidInput();
                temp = Util.GetInt();
            }
            height = temp;
        }
    }

    public Person Father
    {
        get { return father; }
        set { father = value; }
    }

    public Person(Name name, int height, Person father)
    {
        this.name = name;
        this.height = height;
        this.father = father;

        if (father != null)
        {
            if (string.IsNullOrWhiteSpace(this.name.SurName))
                this.name.SurName = father.Name.SurName;

            if (string.IsNullOrWhiteSpace(this.name.LastName))
                this.name.LastName = father.Name.FirstName + "ович";
        }
    }

    public Person(string firstName, int height) : this(new Name(firstName), height, null) { }

    public Person(string firstName, int height, Person father) : this(new Name(firstName), height, father) { }

    public Person(Name name, int height) : this(name, height, null) { }

    public override string ToString()
    {
        return $"{Name}, рост {height}";
    }
}
