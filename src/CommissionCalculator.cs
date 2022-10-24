using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommissionCalculator
{
    public class CommissionCalculator
    {
        public const decimal CommissionPerCarSold = 250;
        public decimal FixedSalary { get; set; }
        public int AmountCarsSold { get; set; }
        public decimal TotalSalesValue { get; set; }
        public decimal FinalSalary { get; set; }

        public void CalculateFinalSalary(decimal fixedSalary, int amountCarsSold, decimal totalSalesValue)
        {
            FixedSalary = fixedSalary;
            AmountCarsSold = amountCarsSold;
            TotalSalesValue = totalSalesValue;

            decimal fixedCommission = CommissionPerCarSold * amountCarsSold;
            decimal commissionPerSale = totalSalesValue * 0.03M;
            FinalSalary = fixedSalary + fixedCommission + commissionPerSale;
        }
    }
}