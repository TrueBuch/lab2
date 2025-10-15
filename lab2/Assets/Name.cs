public class Name
{
    private string firstName;
    private string surName;

    private string lastName;

    public string FirstName
    {
        get { return firstName; }
        set { firstName = value; }
    }


    public string SurName
    {
        get { return surName; }
        set { surName = value; }
    }


    public string LastName
    {
        get { return lastName; }
        set { lastName = value; }
    }

    public Name(string firstName, string surName, string lastName)
    {
        this.firstName = firstName;
        this.surName = surName;
        this.lastName = lastName;
    }
    
    public Name(string firstName) : this(firstName, null, null) { }

    public Name(string firstName, string surName) : this(firstName, surName, null) { }



    public override string ToString()
    {
        string str = "";
        foreach (string field in new[] { surName, firstName, lastName })
            if (!string.IsNullOrWhiteSpace(field)) str += $" {field}";

        return str;
    }
}