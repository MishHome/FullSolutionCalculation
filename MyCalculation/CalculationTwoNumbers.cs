﻿namespace MyCalculation;

public class CalculationTwoNumbers : Calculation, IInputHandler, IGetResult
{
    public decimal A { get; set; }
    public decimal B { get; set; }
    public decimal Result { get; private set; }

    public bool CheckStringToValue(string myString)
    {
        bool result = decimal.TryParse(myString.Trim(), out decimal x);
        return result;
    }

    public override void Adition()
    {
        try
        {
            if ((A == decimal.MaxValue && B > 0) || (A > 0 && B == decimal.MaxValue))
            {
                throw new OverflowException("Результат вышел за допустимый диапазон");
            }
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
        catch (Exception)
        {
            throw;
        }
    }

    public override void Substraction()
    {
        try
        {
            if (A == decimal.MinValue && B > 0)
            {
                throw new OverflowException("Результат вышел за допустимый диапазон");
            }

            Result = A - B;
        }
        catch (OverflowException)
        {

            throw new OverflowException("Результат вышел за допустимый диапазон");
        }
        catch (Exception)
        {
            throw;
        }
    }

    public string GetResult(string s1, string s2, MyActions action)
    {
       
        if (CheckStringToValue(s1) && CheckStringToValue(s2))
        {

            A = decimal.Parse(s1);
            B = decimal.Parse(s2);


            try
            {
                SelectedAction(action);
                return Result.ToString();
            }
            catch
            {
                throw;
            }
            
        }
        else
        {
            return "";
        }
    }
}
