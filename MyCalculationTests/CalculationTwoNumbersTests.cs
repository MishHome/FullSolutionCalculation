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
    public void DivisionTests(double x,double y,double expected)
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
    public void DivisionTestsDivisionZero(double x,double y)
    {
        //Arange
        CalculationTwoNumbers sut = new CalculationTwoNumbers();
        sut.A = x;
        sut.B = y;
        //Act


        //Assert
        Assert.Equal(x, sut.A);
        Assert.Equal(y, sut.B);
        DivideByZeroException actualExeption = Assert.Throws<DivideByZeroException>(()=>sut.Division());
        Assert.Equal("На ноль делить нельзя",actualExeption.Message); 
       
    }
}