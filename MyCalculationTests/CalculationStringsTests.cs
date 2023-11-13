using MyCalculation;

namespace MyCalculationTests
{
    public class CalculationStringsTests
    {
        [Fact]
        public void AdditionTests()
        {
            //Arange
            IGetResult sut = new CalculationStrings();
            string s1 = "1   ";
            string s2 = "2";
            string expected = "12";

            //Act
            string result = sut.GetResult(s1, s2, Calculation.MyActions.Сложение);

            //Assert
            Assert.NotNull(sut);

            Assert.Equal(expected,result);

        }
    }
}
