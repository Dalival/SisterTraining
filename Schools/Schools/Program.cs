using Schools;

var students = new List<Student>
{
    new Student("Egor", "Fedorenko", 9),
    new Student("Maksim", "Sidun", "30-06-2006", 9, new List<int> { 2, 6, 10, 3 }),
    new Student("Anastasia", "Germun", "23-10-2007", 11, new List<int> { 10, 9, 8, 4, 9 }),
    new Student("Ivan", "Starkov", "28-02-2007", 11, new List<int> { 10, 9, 9, 8, 4, 6 })
};

var teachers = new List<Teacher>
{
    new Teacher("Olga", "Kudachko", "English"),
    new Teacher("Yuriy", "Panasevich", "History"),
    new Teacher("Nataliya", "Lyashko", "Matemathic", "14-11-1980", 9),
    new Teacher("Kakashka", "Piska", "English")
};

var school = new School("n20", "Brest", students, teachers);

Console.WriteLine($"Количество учеников из 9 класса: {school.StudentCount(9)}"); //2
Console.WriteLine($"\nОбщее количество учеников: {school.StudentsCount()}"); //4
Console.WriteLine($"\nОбщее количество учителей: {school.TeachersCount()}"); //4
Console.WriteLine($"\nКоличество учителей по английскому языку: {school.TeachersCount("English")}"); //2
Console.WriteLine($"\nСредняя оценка по школе: {school.GetAverageMark()}"); //7.13
Console.WriteLine("\nДобавим пару оценок :)");

Console.WriteLine($"\nСредняя оценка по школе: {school.GetAverageMark()}"); //7.13

school.Students[2].AddMark(9);
school.Students[1].AddMark(10);

Console.WriteLine($"\nНовая средняя оценка по школе: {school.GetAverageMark()}"); //чуть больше чем 7.13
