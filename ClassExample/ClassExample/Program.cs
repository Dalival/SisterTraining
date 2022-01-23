using ClassExample;

var sonya = new Student("Sofia", "Fedorenko", 9);
sonya.Marks = new List<int> { 9, 10, 10, 10 };

Console.WriteLine(sonya.GetDescription());

var num = 3.17;
Console.WriteLine(num);

var petrovich = new Changer();
num = petrovich.Change(num); // here we return a new instance, because 'double' is a primitive (stored in stack)
petrovich.Change(sonya); // here the Change() method will modify exactly 'sonya' instance, because 'Student' is a class (stored in heap)

Console.WriteLine(num);
Console.WriteLine(sonya.GetDescription());
