using Xunit;
using FluentAssertions;

namespace CommissionCalculation.Test;

public class CommissionCalculationTest
{
    [Theory(DisplayName = "Deve Calcular corretamente o salário e armazenar o resultado no atributo FinalSalary.")]
    [InlineData(1500, 2, 50000, 3500)]
    public void TestCalculateFinalSalary(decimal fixedSalary, int amountCarsSold, decimal totalSalesValue, decimal expectedFinalSalary)
    {
        var instance = new CommissionCalculator();

        instance.CalculateFinalSalary(fixedSalary, amountCarsSold, totalSalesValue);
        instance.FinalSalary.Should().Be(expectedFinalSalary);
    }

    [Theory(DisplayName = "Deve exibir corretamente a mensagem de salário final.")]
    [InlineData("Nome Contribuidor", "janeiro", new string[] {
        " O colaborador Nome Contribuidor neste mês de janeiro obteve o salário final de R$ 0,00 referente à: ",
        " SALÁRIO FIXO: R$ 0,00",
        " TOTAL DE CARROS VENDIDOS: 0",
        " VALOR TOTAL DE VENDAS NO MÊS: R$ 0,00",
        " COMISSÃO POR CARROS VENDIDOS: R$ 0,00",
        " COMISSÃO DE 3% DO TOTAL DE VENDAS: R$ 0,00"
    })]
    public void TestShowFinalSalary(string contributorName, string month, string[] expectedMessage)
    {
        var instance = new CommissionCalculator();

        var result = instance.ShowFinalSalary(contributorName, month);
        Assert.Contains(result, x => x.Equal(expectedMessage[0]));
    }
}