namespace SchoolsLinq;

public class Student : Human
{
    public int ClassNumber { get; set; }

    public List<int> Marks { get; set; }

    public double AverageMark => Marks.Average();

    public Student(string firstName, string secondName, int classNumber, List<int> marks = null)
        : base(firstName, secondName)
    {
        ClassNumber = classNumber;
        Marks = marks;
    }
}
