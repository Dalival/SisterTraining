using Calculations;

Console.WriteLine("Choose action: \n1.Sum \n2.Subtraction \n3.Division \n4.Multiplication");
var calculator = new Calculator();
while (true)
{
    var action = Console.ReadLine();
    if (action != "1" && action != "2" && action != "3" && action != "4")
    {
        Console.WriteLine("Wrong input. Try again.");
        continue;
    }

    Console.WriteLine("Enter two numbers:");
    while (true)
    {
        var input1 = Console.ReadLine();
        if (!double.TryParse(input1, out var num1))
        {
            Console.WriteLine("Wrong input. Try again.");
            continue;
        }

        var input2 = Console.ReadLine();
        if (!double.TryParse(input2, out var num2))
        {
            Console.WriteLine("Wrong input. Try again.");
            continue;
        }

        double result;
        switch (action)
        {
            case "1":
                result = calculator.Sum(num1, num2);
                break;
            case "2":
                result = calculator.Subtract(num1, num2);
                break;
            case "3":
                result = calculator.Divide(num1, num2);
                if (double.IsInfinity(result))
                {
                    Console.WriteLine("Can't divide by 0. Try again.");
                    continue;
                }
                break;
            case "4":
                result = calculator.Multiple(num1, num2);
                break;
            default:
                Console.WriteLine("Wrong input. Try again.");
                continue;

        }
        Console.WriteLine("Result is: " + result);
        break;
    }
    break;
}
