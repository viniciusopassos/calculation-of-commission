using CommissionCalculation;

var commissionCalculation = new CommissionCalculator();

commissionCalculation.CalculateFinalSalary(1500, 2, 50000);

string[] message = commissionCalculation.ShowFinalSalary("Vipa", "Abril");

Console.WriteLine(String.Join("\n", message)); // String.Join vai juntar todas as strings dentro do array e separar pelo \n