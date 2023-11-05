namespace MyCalculation;

public class CalculationTwoNumbers : Calculation
{
    int A { get; set; }
    int B { get; set; }
    int Result { get; set; }
    public override void Adition()
    {
        Result = A + B;
    }

    public override void Division()
    {
        throw new NotImplementedException();
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