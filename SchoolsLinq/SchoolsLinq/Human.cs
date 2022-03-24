namespace SchoolsLinq;

public abstract class Human
{
    public string FirstName { get; set; }

    public string SecondName { get; set; }

    protected Human(string firstName, string secondName)
    {
        FirstName = firstName;
        SecondName = secondName;
    }
}
