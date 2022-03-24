using SchoolsLinq;

var students = new List<Student>
{
    new Student("Sofia", "Fedorenko", 9, new List<int> {9, 9, 4, 7, 4, 6}),
    new Student("Egor", "Fedorenko", 9, new List<int> {3, 6, 8, 3, 7, 9, 4}),
    new Student("Artem", "Zotov", 9, new List<int> {8, 4, 8, 5, 2, 6, 8}),
    new Student("Masha", "Bobrova", 9, new List<int> {5, 7, 4}),
    new Student("Alina", "Bartsevich", 9, new List<int> {3, 5}),
    new Student("Makka", "Rukmanova", 9, new List<int> {3, 6, 8, 4, 5, 7, 6}),
    new Student("Madina", "Rukmanova", 9, new List<int> {7, 3, 6, 8}),
    new Student("Nikita", "Vaizin", 9, new List<int> {2, 5}),
    new Student("Alexey", "Knyazev", 9, new List<int> {3, 5, 7, 8, 5, 2, 5, 7, 8}),
};

var teachers = new List<Teacher>
{
    new Teacher("Alexandra", "Evgenyevna", "English", 9),
    new Teacher("Olga", "Ivanovna", "English"),
    new Teacher("Natalia", "Alexeevna", "Math", 5),
    new Teacher("Ksenia", "Nikolaevna", "Math", 11),
    new Teacher("Marina", "Evgenyevna", "Math"),
    new Teacher("Yuriy", "Vladimirovich", "History", 6),
    new Teacher("Alexander", "Alexeevich", "History", 7),
    new Teacher("Alexander", "Egorovich", "Geography"),
    new Teacher("Svetlana", "Ivanovna", "Chemistry", 8),
    new Teacher("Natalia", "Zbihnerovna", "PE", 9),
    new Teacher("Maria", "Ivanovna", "PE"),
    new Teacher("Kamila", "Evgenyevna", "PE", 5),
    new Teacher("Arina", "Nikolaevna", "PE"),
    new Teacher("Nadezhda", "Genadievna", "Work", 4),
    new Teacher("Diana", "Zbihnerovna", "Work", 10),
    new Teacher("Katerina", "Alexeevna", "Work"),
    new Teacher("Dina", "Nikolaevna", "Physics"),
    new Teacher("Barbara", "Ivanovna", "Physics", 6)
};

var schools = new List<School>
{
    new School("Brest", 20, teachers.Take(7).ToList(), students.Take(7).ToList()),
    new School("Brest", 5, teachers.SkipLast(2).TakeLast(7).ToList(), students.SkipLast(3).TakeLast(3).ToList()),
    new School("Brest", 22, teachers.TakeLast(7).ToList(), students.TakeLast(7).ToList()),
    new School("Grodno", 13, teachers.Skip(3).Take(11).ToList(), students.Skip(2).Take(4).ToList()),
    new School("Grodno", 1, teachers.TakeLast(5).ToList(), students.TakeLast(5).ToList()),
    new School("Minsk", 1, teachers.SkipLast(3).TakeLast(11).ToList(), students.SkipLast(2).TakeLast(4).ToList()),
    new School("Minsk", 3, teachers.Take(4).ToList(), students.Take(5).ToList()),
    new School("Minsk", 4, teachers.Skip(4).Take(9).ToList(), students.Skip(2).Take(6).ToList()),
    new School("Minsk", 5, teachers.TakeLast(14).ToList(), students.TakeLast(8).ToList()),
    new School("Vitebsk", 32, teachers.Skip(2).Take(7).ToList(), students.Skip(3).Take(3).ToList()),
    new School("Vitebsk", 14, teachers.Take(12).ToList(), students.Take(6).ToList()),
    new School("Vitebsk", 16, teachers.SkipLast(4).TakeLast(9).ToList(), students.SkipLast(2).TakeLast(6).ToList())
};

var brestSchoolsCount = schools.Count(s => s.City.ToUpper() == "Brest".ToUpper());

var bigSchools = schools
    .Where(s => s.Students.Count >= 5 && s.Teachers.Count >= 3)
    .ToList();

var schoolWithWorstAvgMark = schools.MinBy(s => s.AverageMark);

var schoolWithPhysicsTeacherOnB = schools
    .FirstOrDefault(s => s.Teachers
        .Any(t => t.FirstName.ToUpper().StartsWith('B')
                  && t.Lesson.ToUpper() == "Physics".ToUpper()));

var bestStudent = schools
    .SelectMany(s => s.Students)
    .Where(s => s.AverageMark >= 8)
    .MaxBy(s => s.AverageMark);

var allTeachers = schools
    .SelectMany(s => s.Teachers)
    .ToList();

var allUsedMarks = schools
    .SelectMany(s => s.Students)
    .SelectMany(s => s.Marks)
    .OrderByDescending(m => m)
    .Distinct()
    .ToList();

// Task with an asterisk:

var schoolTeachers = schools.Select(s => s.Teachers);

var biggestGroupsOfSchools = new List<List<Teacher>>();
foreach (var teachersList in schoolTeachers)
{
    var groupsByLesson = teachersList.GroupBy(x => x.Lesson);
    var biggestGroupOfSchool = groupsByLesson.MaxBy(x => x.Count())?.ToList();
    biggestGroupsOfSchools.Add(biggestGroupOfSchool);
}

var biggestGroupEver = biggestGroupsOfSchools.MaxBy(x => x.Count);

foreach (var teacher in biggestGroupEver)
{
    Console.WriteLine(teacher.FirstName + " " + teacher.SecondName);
}

// Same task but with LINQ:

Console.WriteLine("*******************");

var biggestTeachersGroup = schools
    .Select(s => s.Teachers)
    .Select(tl => tl
        .GroupBy(x => x.Lesson)
        .MaxBy(x => x.Count())?
        .ToList())
    .MaxBy(x => x?.Count);

foreach (var teacher in biggestTeachersGroup)
{
    Console.WriteLine(teacher.FirstName + " " + teacher.SecondName);
}
