namespace MyCalculation;

public class CalculationTwoNumbers : Calculation
{
    public decimal A { get; set; }
    public decimal B { get; set; }
    public decimal Result { get; set; }
    public override void Adition()
    {
        try
        {
            Result = A + B;
        }
        catch (OverflowException)
        {
            throw new OverflowException("Результат вышел за допустимый диапазон");
        }
        catch(Exception) 
        { 
            throw;
        }
    }

    public override void Division()
    {
        if (B == 0)
        {
            throw new DivideByZeroException("На ноль делить нельзя");
        }
        else
        {
            Result = A / B;
        }
        
    }

    public override void Multiplication()
    {
        try
        {
            Result = A * B;
        }
        catch (OverflowException)
        {

            throw new OverflowException("Результат вышел за допустимый диапазон");
        }
    }

    public override void Substraction()
    {
        Result = A - B;
    }
}