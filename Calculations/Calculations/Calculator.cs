namespace Calculations;

public class Calculator
{
    public double Multiple(double num1 , double num2)
    {
        var result = num1 * num2;
        return result;
    }

    public double Divide(double num1 , double num2)
    {
        var result = num1 / num2;
        return result;
    }

    public double Sum(double num1 , double num2)
    {
        var result = num1 + num2;
        return result;
    }

    public double Subtract(double num1 , double num2)
    {
        var result = num1 - num2;
        return result;
    }
}
