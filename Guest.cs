using System;

public class Guest
{
    public string Name { get; set; }
    public double Budget { get; set; }

    public Guest(string name, double budget)
    {
        Name = name;
        Budget = budget;
    }

    public void BuyDrink(Drink drink)
    {
        if (Budget >= drink.Price)
        {
            Budget -= drink.Price;
            Console.WriteLine($"{Name} купил {drink.Name}");
        }
        else
        {
            Console.WriteLine($"{Name} не хватает денег!");
        }
    }
}