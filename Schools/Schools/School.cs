namespace Schools;
    public class School
{
    public string Name { get; set; }

    public string City { get; set; }

    public List<Student> Students { get; set; }

    public List<Teacher> Teachers { get; set; }

    public School(string name, string city )
    {
        Name = name;
        City = city;
        Students = new List<Student>();
        Teachers = new List<Teacher>();
    }

    public School(string name, string city, List<Student> students, List<Teacher> teachers)
        : this(name, city)
    {
        Students = students;
        Teachers = teachers;
    }

    public double GetAverageMark()
    {
        var allMarks = new List<int>();
        foreach (var student in Students)
        {
            var marks = student.Marks;
            allMarks.AddRange(marks);
        }

        return allMarks.Average();
    }

    public int StudentsCount()
    {
        return Students.Count;
    }

    public int StudentCount(int form)
    {
        var count = 0;
        foreach(var student in Students)
        {
            if (student.Form == form)
            {
                count++;
            }
        }
        return count;
    }

    public int TeachersCount() => Teachers.Count; 

    public int TeachersCount(string lesson)
    {
        var count = 0;
        foreach (var teacher in Teachers)
        {
            if (teacher.Lesson.ToUpper() == lesson.ToUpper())
            {
                count++;
            }
        }

        return count;
    }
}
