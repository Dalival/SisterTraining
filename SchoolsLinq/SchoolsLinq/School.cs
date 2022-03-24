namespace SchoolsLinq;

public class School
{
    public string City { get; set; }

    public int Number { get; set; }

    public List<Teacher> Teachers { get; set; }

    public List<Student> Students { get; set; }

    public double AverageMark => Students.Select(s => s.AverageMark).Average();

    public School(string city, int number, List<Teacher> teachers = null, List<Student> students = null)
    {
        City = city;
        Number = number;
        Teachers = teachers;
        Students = students;
    }
}
