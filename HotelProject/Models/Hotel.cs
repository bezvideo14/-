using System.Collections.Generic;

public class Hotel
{
    public string Name { get; set; }
    public HotelClass Class { get; set; }
    public List<Room> Rooms { get; set; } = new List<Room>();

    public double GetRoomPrice(Room room)
    {
        double multiplier = (int)Class;

        return room.GetPrice() * multiplier;
    }
}