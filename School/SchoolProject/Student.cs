namespace SchoolProject;

public class Student : Human
{
    public int Form { get; set; }
    public List<int> Marks { get; set; }

    public Student(string name, string secondName, string dateOfBirth, int form, List<int> marks)
        : base(name, secondName, dateOfBirth)
    {
        Form = form;
        Marks = marks;
    }

    public double GetAverageMark()
    {
        return Marks.Average();
    }
}
