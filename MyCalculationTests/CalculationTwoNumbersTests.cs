using MyCalculation;

namespace MyCalculationTests
{
    public class CalculationTwoNumbersTests
    {
        [Fact]
        public void AdditionTests()
        {
            //Arange
            Calculation sut = new CalculationTwoNumbers() { A = 1, B = 2 };
            CalculationTwoNumbers inheritClass = (CalculationTwoNumbers)sut;
            decimal expected = 3;

            //Act
            sut.Adition();

            //Assert
            Assert.NotNull(sut);
            Assert.Equal(1, inheritClass.A);
            Assert.Equal(2, inheritClass.B);

            Assert.Equal(expected, inheritClass.Result);

        }

        [Theory]
        [InlineData(4, 2, 2)]
        [InlineData(1, 2, 0.5)]
        [InlineData(0, 2, 0)]
        public void DivisionTests(decimal x, decimal y, decimal expected)
        {
            //Arange
            Calculation sut = new CalculationTwoNumbers() { A = x, B = y };
            CalculationTwoNumbers inheritClass = (CalculationTwoNumbers)sut;
            
            //Act
            sut.Division();

            //Assert
            Assert.Equal(x, inheritClass.A);
            Assert.Equal(y, inheritClass.B);
            Assert.Equal(expected, inheritClass.Result);
        }

        [Theory]
        [InlineData(4, 0)]
        [InlineData(0, 0)]
        public void DivisionTestsDivisionZero(decimal x, decimal y)
        {
            //Arange
            Calculation sut = new CalculationTwoNumbers() { A = x, B = y };
            CalculationTwoNumbers inheritClass = (CalculationTwoNumbers)sut;

            //Act
            Action action = delegate
            {
                sut.Division();
            };

            //Assert
            Assert.Equal(x, inheritClass.A);
            Assert.Equal(y, inheritClass.B);
            var actualExeption = Assert.Throws<DivideByZeroException>(action);
            Assert.Equal("На ноль делить нельзя", actualExeption.Message);
        }

        [Theory]
        [InlineData(4, 0, 4)]
        [InlineData(0, 0, 0)]
        [InlineData(-1, -2, 1)]
        public void SubstractionTests(decimal x, decimal y, decimal expected)
        {
            //Arange
            Calculation sut = new CalculationTwoNumbers() { A = x, B = y };
            CalculationTwoNumbers inheritClass = (CalculationTwoNumbers)sut;

            //Act
            sut.Substraction();

            //Assert
            Assert.Equal(x, inheritClass.A);
            Assert.Equal(y, inheritClass.B);
            Assert.Equal(expected, inheritClass.Result);
        }

        [Theory]
        [InlineData(4, 0, 0)]
        [InlineData(0, 0, 0)]
        [InlineData(-1, -2, 2)]
        public void MultiplicationTests(decimal x, decimal y, decimal expected)
        {
            //Arange
            Calculation sut = new CalculationTwoNumbers() { A = x, B = y };
            CalculationTwoNumbers inheritClass = (CalculationTwoNumbers)sut;

            //Act
            sut.Multiplication();

            //Assert
            Assert.Equal(x, inheritClass.A);
            Assert.Equal(y, inheritClass    .B);
            Assert.Equal(expected, inheritClass.Result);
        }

        [Fact]
        public void AdditionTestsOverflow()
        {
            //Arange
            Calculation sut = new CalculationTwoNumbers() { A = decimal.MaxValue, B = 0.01M };
            CalculationTwoNumbers inheritClass = (CalculationTwoNumbers)sut;

            //Act
            Action action = delegate
            {
                sut.Adition();
            };

            //Assert
            var actualExeption = Assert.Throws<OverflowException>(action);
            Assert.Equal("Результат вышел за допустимый диапазон", actualExeption.Message);
        }

        [Fact]
        public void MultiplicationTestsOverflow()
        {
            //Arange
            Calculation sut = new CalculationTwoNumbers() { A = decimal.MaxValue, B = 1.01M };
            CalculationTwoNumbers inheritClass = (CalculationTwoNumbers)sut;

            //Act
            Action action = delegate
            {
                sut.Multiplication();
            };

            //Assert
            var actualExeption = Assert.Throws<OverflowException>(action);
            Assert.Equal("Результат вышел за допустимый диапазон", actualExeption.Message);
        }

        [Fact]
        public void SubstractionTestsOverflow()
        {
            //Arange
            Calculation sut = new CalculationTwoNumbers() { A = decimal.MinValue, B = 0.01M };
            CalculationTwoNumbers inheritClass = (CalculationTwoNumbers)sut;

            //Act
            Action action = delegate
            {
                sut.Substraction();
            };

            //Assert
            var actualExeption = Assert.Throws<OverflowException>(action);
            Assert.Equal("Результат вышел за допустимый диапазон", actualExeption.Message);
        }

        [Theory]
        [InlineData("1")]
        [InlineData("2")]
        [InlineData("0")]
        [InlineData("-1")]
        [InlineData("  1   ")]
        [InlineData("1,1")]
        public void CheckStringToValuePassing(string s)
        {
            //Arange
            CalculationTwoNumbers sut = new CalculationTwoNumbers();

            //Act
            var result = sut.CheckStringToValue(s);

            //Assert
            Assert.True(result);
        }

        [Theory]
        [InlineData("s")]
        [InlineData("-")]
        [InlineData("huhf6")]
        [InlineData("")]
        [InlineData("1.1")]

        public void CheckStringToValueFailing(string s)
        {
            //Arange
            CalculationTwoNumbers sut = new CalculationTwoNumbers();

            //Act
            var result = sut.CheckStringToValue(s);

            //Assert
            Assert.False(result);
        }
    }
}
