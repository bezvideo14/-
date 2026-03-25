using System;

public class Manager : Employee
{
    public Manager(string name, double salary) : base(name, salary) { }

    public void CheckRoom(Room room, Housekeeper housekeeper)
    {
        if (!room.IsClean)
        {
            housekeeper.Salary *= 0.99;
            Console.WriteLine("Штраф горничной 1%");
        }
        else
        {
            Console.WriteLine("Все чисто 👍");
        }
    }
}