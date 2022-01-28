namespace SchoolProject;

public class Human
{
    public string Name { get; set; }
    public string SecondName { get; set; }
    public string DateOfBirth { get; set; }

    public Human(){}

    public Human(string name, string secondName, string dateOfBirth)
    {
        Name = name;
        SecondName = secondName;
        DateOfBirth = dateOfBirth;
    }
}
