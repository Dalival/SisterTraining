var menuOfPizzas = "Choose a pizza:"
                   + "\n1. Pepperoni - 6$"
                   + "\n2. Ham ahd cheese - 8$"
                   + "\n3. Cheese - 4$"
                   + "\n4. Prosciutto - 7$"
                   + "\n5. Capricciosa - 8$";
var menuOfOptions = "Select an action:"
                    + "\n1. Add another pizza"
                    + "\n2. Final check";
var finalCheck = 0;

while (true)
{
    // choosing a pizza
    Console.WriteLine(menuOfPizzas);
    while (true)
    {
        string pizzaName;
        switch (Console.ReadLine())
        {
            case "1":
                finalCheck += 6;
                pizzaName = "Pepperoni";
                break;
            case "2":
                finalCheck += 8;
                pizzaName = "Ham and cheese";
                break;
            case "3":
                finalCheck += 4;
                pizzaName = "Cheese";
                break;
            case "4":
                finalCheck += 7;
                pizzaName = "Prosciutto";
                break;
            case "5":
                finalCheck += 8;
                pizzaName = "Capricciosa";
                break;
            default:
                Console.WriteLine("Wrong input. Try again.");
                continue;
        }

        Console.WriteLine("You choose " + pizzaName +
                          "\nYour check - " + finalCheck + "$");
        break;
    }

    // choosing an option
    Console.WriteLine(menuOfOptions);
    while (true)
    {
        var input = Console.ReadLine();

        if (input == "1")
        {
            break;
        }

        if (input == "2")
        {
            Console.WriteLine("Final check: " + finalCheck + "$");
            return;
        }

        Console.WriteLine("Wrong input. Try again.");
    }
}
