using System;
using System.Collections.Generic;

public class SalaryService
{
    public void PaySalaries(List<Employee> employees)
    {
        foreach (var emp in employees)
        {
            Console.WriteLine($"{emp.Name} получил зарплату: {emp.Salary}");
        }
    }
}