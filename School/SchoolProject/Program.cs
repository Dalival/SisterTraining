using SchoolProject;

var sonya = new Student("Sofia", "Fedorenko", "23.09.2006", 9, new List<int> {9, 9, 8, 7});
Console.WriteLine("Second name: " + sonya.SecondName);
sonya.SecondName = "Spirina";
