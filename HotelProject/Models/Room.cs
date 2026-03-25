public class Room
{
    public int Number { get; set; }
    public double BasePrice { get; set; }
    public bool IsClean { get; set; } = true;
    public RoomType Type { get; set; }
    public Fridge Fridge { get; set; } = new Fridge();

    public double GetPrice()
    {
        if (Type == RoomType.SeaView)
            return BasePrice * 1.2;

        return BasePrice;
    }
}