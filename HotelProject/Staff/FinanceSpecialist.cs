using System;

public class FinanceSpecialist : Employee
{
    public FinanceSpecialist(string name, double salary) : base(name, salary) { }

    public void CheckIncome(double income)
    {
        Console.WriteLine($"Доход отеля: {income}");
    }
}