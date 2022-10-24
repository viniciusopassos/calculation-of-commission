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
    }
}