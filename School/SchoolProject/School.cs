namespace SchoolProject;

public class School
{
    public string Name { get; set; }
    public string City { get; set; }
    public List<Student> Students { get; set; }
    public List<Teacher> Teachers { get; set; }

    public School(string name, string city)
    {
        Name = name;
        City = city;
    }

    public School(string name, string city, List<Student> students, List<Teacher> teachers)
        : this(name, city)
    {
        Students = students;
        Teachers = teachers;
    }
}
