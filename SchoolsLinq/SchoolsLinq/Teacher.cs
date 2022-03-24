namespace SchoolsLinq;

public class Teacher : Human
{
    public int? ClassNumber { get; set; }

    public string Lesson { get; set; }

    public Teacher(string firstName, string secondName, string lesson, int? classNumber = null)
        : base(firstName, secondName)
    {
        Lesson = lesson;
        ClassNumber = classNumber;
    }
}
