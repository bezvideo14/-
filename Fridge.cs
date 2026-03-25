using System.Collections.Generic;

public class Fridge
{
    public List<Drink> Drinks { get; set; } = new List<Drink>();

    public void AddDrink(Drink drink)
    {
        Drinks.Add(drink);
    }
}