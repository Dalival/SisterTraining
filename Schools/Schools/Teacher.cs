namespace Schools;
public class Teacher : Human
{
    public string Lesson { get; set; }
    public int Form { get; set; }

    public Teacher(string name, string surname, string lesson) : base(name, surname)
    {
        Lesson = lesson;
    }

    public Teacher(string name, string surname, string lesson, string dateOfBirth, int form)
            : base(name, surname, dateOfBirth)
    {
        Form = form;
        Lesson = lesson;
    }
}
