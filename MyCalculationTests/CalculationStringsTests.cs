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

            Assert.Equal(expected, result);


        }

        //[Theory]
        ////[InlineData("s","")]
        ////[InlineData("-","")]
        ////[InlineData("huhf6","")]
        //[InlineData("", "")]
        ////[InlineData("1.1","")]

        //public void AdditionTestsFailing(string s1, string s2)
        //{
        //    //Arange
        //    IGetResult sut = new CalculationStrings();

        //    //Act
        //    var result = sut.GetResult(s1, s2, Calculation.MyActions.Сложение);

        //    //Assert
        //    Assert.False(result);
        //}
        [Fact]
        private void AdditionTestsFailing()
        {
            //Arange
            IGetResult sut = new CalculationStrings();
            string s1 = " ";
            string s2 = " ";
            string expected = "Введите символы";

            //Act
            string result = sut.GetResult(s1, s2, Calculation.MyActions.Сложение);

            //Assert
            Assert.NotNull(sut);

            Assert.Equal(expected, result);
        }
    }
}
