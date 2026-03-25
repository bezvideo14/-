

class Program
{
    static void Main()
    {
        
        Hotel hotel = new Hotel { Name = "Sea Hotel", Class = HotelClass.FiveStars };
        
        Room room = new Room
        {
            Number = 1,
            BasePrice = 100,
            Type = RoomType.SeaView,
            IsClean = false
        };

        room.Fridge.AddDrink(new Drink("Cola", 5));
        room.Fridge.AddDrink(new Drink("Juice", 7));

        hotel.Rooms.Add(room);
        
        Guest guest = new Guest("Ivan", 10);
        
        guest.BuyDrink(room.Fridge.Drinks[0]);
        
        Housekeeper housekeeper = new Housekeeper("Anna", 1000);
        Manager manager = new Manager("Boss", 2000);
        FinanceSpecialist finance = new FinanceSpecialist("Fin", 1500);
        
        manager.CheckRoom(room, housekeeper);

        housekeeper.CleanRoom(room);

        finance.CheckIncome(5000);

        SalaryService salaryService = new SalaryService();

        salaryService.PaySalaries(new List<Employee>
        {
            housekeeper,
            manager,
            finance
        });

        Console.WriteLine("Готово ✅");
    }
}