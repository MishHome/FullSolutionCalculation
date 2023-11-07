namespace MyCalculation;

public abstract class Calculation
{
    public enum MyActions {Сложение, Вычитание, Деление, Умножение }
    public abstract void Adition();
    public abstract void Substraction();
    public abstract void Multiplication();
    public abstract void Division();

    public void SelectedAction(MyActions actions)
    {
        switch (actions)
        {
            case MyActions.Сложение:
                Adition();
                break;
            case MyActions.Вычитание:
                Substraction();
                break;
            case MyActions.Деление:
                Division();
                break;
            case MyActions.Умножение:
                Multiplication();
                break;
            default:
                break;
        }
    }
}
