using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommissionCalculation
{
    public class CommissionCalculator
    {
        public const decimal CommissionPerCarSold = 250;
        public decimal FixedSalary { get; set; }
        public int AmountCarsSold { get; set; }
        public decimal TotalSalesValue { get; set; }
        public decimal FinalSalary { get; set; }
        public decimal FixedCommission { get; set; }
        public decimal CommissionPerSale { get; set; }

        public decimal CalculateFinalSalary(decimal fixedSalary, int amountCarsSold, decimal totalSalesValue)
        {
            FixedSalary = fixedSalary;
            AmountCarsSold = amountCarsSold;
            TotalSalesValue = totalSalesValue;

            decimal fixedCommission = CommissionPerCarSold * amountCarsSold;
            decimal commissionPerSale = totalSalesValue * 0.03M;
            FinalSalary = fixedSalary + fixedCommission + commissionPerSale;

            return FinalSalary;
        }

        public string[] ShowFinalSalary(string contributorName, string month)
        {
            return new string[]
            {" O colaborador " + contributorName + " neste mês de " + month + " obteve o salário final de R$ " + FinalSalary + " referente à: ", 
            " SALÁRIO FIXO: R$ " + FixedSalary,
            " TOTAL DE CARROS VENDIDOS: " + AmountCarsSold,
            " VALOR TOTAL DE VENDAS NO MÊS: R$ " + TotalSalesValue,
            " COMISSÃO POR CARROS VENDIDOS: R$ " + FixedCommission,
            " COMISSÃO DE 3% DO TOTAL DE VENDAS: R$ " + CommissionPerSale,
            }; 
        }
    }
}