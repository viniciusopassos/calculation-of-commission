using CommissionCalculation;

var commissionCalculation = new CommissionCalculator();

decimal finalSalary = commissionCalculation.CalculateFinalSalary(1500, 2, 50000);

Console.WriteLine("O salário final do colaborador é: R$" + finalSalary);