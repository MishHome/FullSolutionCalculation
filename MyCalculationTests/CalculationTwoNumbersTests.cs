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
}