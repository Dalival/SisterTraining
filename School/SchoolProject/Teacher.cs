namespace SchoolProject;

public class Teacher : Human
{
    public string Lesson { get; set; }
    public int Form { get; set; }

    public Teacher(string name, string secondName, string dateOfBirth, string lesson, int form)
        : base(name, secondName, dateOfBirth)
    {
        Lesson = lesson;
        Form = form;
    }
}
