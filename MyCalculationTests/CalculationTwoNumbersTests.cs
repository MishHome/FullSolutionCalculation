using MyCalculation;
using System.ComponentModel;

namespace MyCalculationTests;

public class CalculationTwoNumbersTests
{


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
        var result=sut.CheckStringToValue(s);

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