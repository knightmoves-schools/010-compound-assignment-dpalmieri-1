namespace Tests;
using knightmoves;
using Xunit;

public class AutogradingTest
{
    [Fact]
    public void Should_Use_Compound_Assignment_To_Add_5_To_The_Addition(){
        var calculator = new Calculator();
        Assert.Equal(50, calculator.Addition);
        calculator.Calculate();
        Assert.Equal(55, calculator.Addition);
    }
    
    [Fact]
    public void Should_Use_Compound_Assignment_To_Subtract_1_From_The_Subtraction(){
        var calculator = new Calculator();
        Assert.Equal(40, calculator.Subtraction);
        calculator.Calculate();
        Assert.Equal(39, calculator.Subtraction);
    }
    
    [Fact]
    public void Should_Use_Compound_Assignment_To_Multiply_The_Multiplication_By_7(){
        var calculator = new Calculator();
        Assert.Equal(5, calculator.Multiplication);
        calculator.Calculate();
        Assert.Equal(35, calculator.Multiplication);
    }
    
    [Fact]
    public void Should_Use_Compound_Assignment_To_Divide_The_Division_By_2(){
        var calculator = new Calculator();
        Assert.Equal(6, calculator.Division);
        calculator.Calculate();
        Assert.Equal(3, calculator.Division);
    }
}