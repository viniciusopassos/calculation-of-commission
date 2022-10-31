using Xunit;
using FluentAssertions;

namespace CommissionCalculation.Test;

public class CommissionCalculationTest
{
    [Theory(DisplayName = "Deve Calcular corretamente o salário e armazenar o resultado no atributo FinalSalary.")]
    [InlineData(1500, 2, 50000, 3500)]
    [InlineData(1500, 0, 50000, 3500)]
    public void TestCalculateFinalSalary(decimal fixedSalary, int amountCarsSold, decimal totalSalesValue, decimal expectedFinalSalary)
    {
        var instance = new CommissionCalculator();

        instance.CalculateFinalSalary(fixedSalary, amountCarsSold, totalSalesValue);
        instance.FinalSalary.Should().Be(expectedFinalSalary);
    }

    [Theory(DisplayName = "Deve exibir corretamente a mensagem de salário final.")]
    [InlineData()]
    public void TestShowFinalSalary(string contributorName, string month, string[] expectedMessage)
    {
        
    }
}