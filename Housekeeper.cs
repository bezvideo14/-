using System;

public class Housekeeper : Employee
{
    public Housekeeper(string name, double salary) : base(name, salary) { }

    public void CleanRoom(Room room)
    {
        room.IsClean = true;
        Console.WriteLine($"Комната {room.Number} убрана");
    }
}