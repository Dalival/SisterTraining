var text = "           Меня зовут Соня, мне 15 лет. " +
           "На данный   момент я учусь   программировать, выполняя задания," +
           " которые мне задал брат. Ёжик умер, ёлка сгорела   мнее         ";
Console.WriteLine(text);
Console.WriteLine("\n 1. Верхний регистор: " + text.ToUpper());
Console.WriteLine("\n Нижний регистор: " + text.ToLower());

var newtext = text.Trim();
Console.WriteLine("\n 2. Убрать все пробелы в начале, в конце строки: " + newtext);

Console.WriteLine("\n 3.Поменять все точки на восклицательный знак, а запятые на точку с запятой: "
                  + newtext.Replace('.', '!').Replace(',', ';'));

Console.WriteLine("\n 4. Коллекия слов: ");
var words = newtext.Split(" ");
foreach (var s in words)
{
    Console.WriteLine(s);
}


Console.WriteLine("\n 5.Все ё заменить на е: " + newtext.Replace('ё', 'е').Replace('Ё', 'Е'));

Console.WriteLine($"\n 6. Количество символов: {newtext.Length}");


double countletters = 0;
foreach (var s in words)
{
    countletters = countletters + s.Length;
}

var mediumofletters = countletters / words.Length;
Console.WriteLine("\n 7. Среднее количество букв в словах: " + mediumofletters);


var s2 = "???";
var task8 = string.Concat(newtext, s2);
Console.WriteLine("\n 8.Соединить две строки: " + task8);

var s3 = "конец.";
var task9 = string.Concat(newtext, "|", s2, "|", s3);
Console.WriteLine($"\n 9. Соединить три строки, между ними поставить | : {task9}");


var task10 = " мне ";
int i = 0;
int x = -1;
int k = -1;
while (i != -1)
{
    i = newtext.IndexOf(task10, x + 1);
    x = i;
    k++;
}

Console.WriteLine("\n 10. В тексте  слово МНЕ повторяется: " + k + " раза");
;


if (newtext.EndsWith("."))
{
    Console.WriteLine("\n 11. Текст заканчивается точкой.");
}

Console.WriteLine("\n 11. Текст не заканчивается точкой.");

var task12 = ",";
int indexoftask12 = newtext.IndexOf(task12);
Console.WriteLine($"\n 12. Впервые в тексте запятая встречается на индексе {indexoftask12}");

int indexoftask121 = newtext.LastIndexOf(task12);
Console.WriteLine($"\n 12.1 В последний раз в тексте запятая встречается на индексе {indexoftask121}");


var task13 = ".";
int indexoftask13 = newtext.IndexOf(task13) + 1;
var sentence = "Это первое предложение.";
newtext = newtext.Insert(indexoftask13, sentence);
Console.WriteLine("\n 13. Вставить предложение: " + newtext);
