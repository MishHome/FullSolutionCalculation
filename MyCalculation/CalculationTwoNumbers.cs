namespace MyCalculation;

public class CalculationTwoNumbers : Calculation
{
    public decimal A { get; set; }
    public decimal B { get; set; }
    public decimal Result { get; set; }
    public override void Adition()
    {
        if (A >= decimal.MaxValue && B > 0)
        {
            throw new ArgumentOutOfRangeException("","Вы вышли за максимальный диапазон одного из аргументов");
        }
        else if (A > 0 && B >= decimal.MaxValue)
        {
            throw new ArgumentOutOfRangeException("","Вы вышли за максимальный диапазон одного из аргументов");
        }
        else
        {
            Result = A + B;
        }
    }

    public override void Division()
    {
        if (B == 0)
        {
            //throw new ArgumentException();
            throw new DivideByZeroException("На ноль делить нельзя");
        }
        else
        {
            Result = A / B;
        }
        
    }

    public override void Multiplication()
    {
        Result = A * B;
    }

    public override void Substraction()
    {
        Result = A - B;
    }
}