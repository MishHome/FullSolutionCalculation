namespace MyCalculation;

public abstract class Calculation:IInputHandler
{
    public abstract void Adition();
    public abstract void Substraction();
    public abstract void Multiplication();
    public abstract void Division();
    public abstract bool CheckStringToValue(string myString);
}
