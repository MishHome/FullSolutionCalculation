using MyCalculation;

namespace MyCalculationTests;

public class CalculationTwoNumbersTests
{
    [Fact]
    public void AdditionTests()
    {
        //Arange
        CalculationTwoNumbers sut = new CalculationTwoNumbers();
        sut.A = 1;
        sut.B = 2;
        int expected = 3;

        //Act
        sut.Adition();

        //Assert
        Assert.Equal(expected, sut.Result);
    }

    [Theory]
    [InlineData(4,2,2)]
    [InlineData(1,2,0.5)]
    [InlineData(0,2,0)]
    public void DivisionTests(decimal x, decimal y, decimal expected)
    {
        //Arange
        CalculationTwoNumbers sut = new CalculationTwoNumbers();
        sut.A = x;
        sut.B = y;

        //Act
        sut.Division();

        //Assert
        Assert.Equal(x, sut.A);
        Assert.Equal(y, sut.B);
        Assert.Equal(expected, sut.Result);
    }

    [Theory]
    [InlineData(4,0)]
    [InlineData(0,0)]
    public void DivisionTestsDivisionZero(decimal x, decimal y)
    {
        //Arange
        CalculationTwoNumbers sut = new CalculationTwoNumbers();
        sut.A = x;
        sut.B = y;

        //Act
        Action action = delegate
        {
            sut.Division();
        };

        //Assert
        Assert.Equal(x, sut.A);
        Assert.Equal(y, sut.B);
        var actualExeption = Assert.Throws<DivideByZeroException>(action);
        Assert.Equal("На ноль делить нельзя",actualExeption.Message);
       
    }

    [Theory]
    [InlineData(4,0,4)]
    [InlineData(0,0,0)]
    [InlineData(-1,-2,1)]
    public void SubstractionTests(decimal x, decimal y, decimal expected)
    {
        //Arange
        CalculationTwoNumbers sut = new CalculationTwoNumbers();
        sut.A = x;
        sut.B = y;

        //Act
        sut.Substraction();

        //Assert
        Assert.Equal(x, sut.A);
        Assert.Equal(y, sut.B);
        Assert.Equal(expected, sut.Result);
    }

    [Theory]
    [InlineData(4, 0, 0)]
    [InlineData(0, 0, 0)]
    [InlineData(-1, -2, 2)]
    public void MultiplicationTests(decimal x, decimal y, decimal expected)
    {
        //Arange
        CalculationTwoNumbers sut = new CalculationTwoNumbers();
        sut.A = x;
        sut.B = y;

        //Act
        sut.Multiplication();

        //Assert
        Assert.Equal(x, sut.A);
        Assert.Equal(y, sut.B);
        Assert.Equal(expected, sut.Result);
    }

    [Fact]
    public void AdditionTestsOverflow()
    {
        //Arange
        CalculationTwoNumbers sut = new CalculationTwoNumbers();
        sut.A = decimal.MaxValue;
        sut.B = 1;

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
        CalculationTwoNumbers sut = new CalculationTwoNumbers();
        sut.A = decimal.MaxValue;
        sut.B = 2;

        //Act
        Action action = delegate
        {
            sut.Multiplication();
        };

        //Assert
        var actualExeption = Assert.Throws<OverflowException>(action);
        Assert.Equal("Результат вышел за допустимый диапазон", actualExeption.Message);
    }

}