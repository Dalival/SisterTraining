namespace ClassExample;

public class Changer
{
    public double Change(double number)
    {
        number += 3;
        number *= 7;
        number += number;

        return number;
    }

    public void Change(Student human)
    {
        human.Name = "Changed by changer";
        human.Surname = "Papapa";
    }
}
