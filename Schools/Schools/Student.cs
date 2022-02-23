namespace Schools;

public class Student : Human
{
    public int Form { get; set; }

    public List<int> Marks { get; set; }

    public Student(string name, string surname, int form)
       : base(name, surname)
    {
        Form = form;
        Marks = new List<int>();
    }

    public Student(string name, string surname, string dateOfBirth, int form, List<int> marks)
        : base(name, surname, dateOfBirth)
    {
        Form = form;
        Marks = marks;
    }

    public void AddMark(int mark) => Marks.Add(mark);

    public double GetAverageMark()
    {
        if (Marks.Count == 0)
        {
            return 0;
        }

        return Marks.Average();
    }
}
