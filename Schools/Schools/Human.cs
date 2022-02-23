namespace Schools;

public class Human
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string DateOfBirth { get; set; }

    public Human(string name, string surname)
    {
        Name = name;
        Surname = surname;
    }

    public Human(string name, string surname, string dateOfBirth)
        : this(name, surname)
    {
        DateOfBirth = dateOfBirth;
    }
}
