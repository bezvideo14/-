public class Drink
{
    public string Name { get; set; }
    public double Price { get; set; }

    public Drink(string name, double price)
    {
        Name = name;
        Price = price;
    }
}