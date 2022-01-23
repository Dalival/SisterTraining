namespace ClassExample;

public class Student
{
    public string Name;
    public string Surname;
    public int Class;
    public List<int> Marks;

    public Student(string n, string sn, int cl)
    {
        Name = n;
        Surname = sn.ToUpper(); // surname will be always in CAPSLOCK
        Class = cl;
    }

    public string GetDescription()
    {
        var description = $"{Name} {Surname} - {Class} class. Average mark - {GetAverageMark()}.";
        if (IsGreater())
        {
            description += " Greater";
        }

        return description;
    }

    public double GetAverageMark()
    {
        var marksSum = 0;

        for (var i = 0; i < Marks.Count; i++)
        {
            var mark = Marks[i];
            marksSum += mark;
        }

        var average = (double) marksSum / Marks.Count;

        return average;
    }

    public bool IsGreater()
    {
        return GetAverageMark() >= 9;
    }
}
