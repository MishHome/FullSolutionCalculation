using System.ComponentModel.Design;

namespace MyCalculation
{
    public class CalculationStrings : Calculation, IInputHandler, IGetResult
    {
        string A { get; set; } = "";
        string B { get; set; } = "";
        string Result { get; set; } = "";
        public override void Adition()
        {
            Result = A.TrimEnd() + B;
        }

        public bool CheckStringToValue(string myString)
        {
            throw new NotImplementedException();
        }

        public override void Division()
        {
            throw new NotImplementedException();
        }

        public string GetResult(string s1, string s2, MyActions action)
        {
            
            
            A = s1;
            B = s2;

                try
                {
                    SelectedAction(action);
                    if (A == " " && B == " ")
                        return "Введите символы";
                    else
                        return Result.ToString();
                }
                catch
                {
                    throw;
                }
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
}
