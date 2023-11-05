namespace MyCalculation;

public class CalculationTwoNumbers : Calculation
{
    public double A { get; set; }
    public double B { get; set; }
    public double Result { get; set; }
    public override void Adition()
    {
        Result = A + B;
    }

    public override void Division()
    {
        if (B == 0)
        {
            throw new DivideByZeroException("На ноль делить нельзя");
        }
        Result = A / B;
    }

    public override void Multiplication()
    {
        throw new NotImplementedException();
    }

    public override void Substraction()
    {
        throw new NotImplementedException();
    }
}