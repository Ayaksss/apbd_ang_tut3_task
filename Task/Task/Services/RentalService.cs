namespace Task.Services;
using Task.Users;
using Task.Equipment;

public class RentalService
{
    List<Rental> rentals = new List<Rental>();
    private double lateFee = 10.0;

    public void rentEquipment(User user, int id, DateTime rentDate, int daysToRent)
    {
        Equipment equipment = InventoryService.findEquipment(id);
        if (equipment.isAvailable == true && user.availableRents > 0)
        {
            rentals.Add(new Rental(user, equipment, rentDate, daysToRent));    
            equipment.isAvailable = false;
            user.availableRents--;
            Console.WriteLine("Successfully rented equipment: " + equipment.name);
        }
        else if (user.availableRents < 0)
        {
            Console.WriteLine(user.firstName + " " + user.lastName + " has exceeded rent limit");
        }
        else if (equipment.isAvailable == false)
        {
            Console.WriteLine(equipment.name + " is not available");
        }
    }
    public void returnItem(int id, DateTime currentDate)
    {
        Equipment equipment = InventoryService.findEquipment(id);
        Rental rental = rentals.Find(x => x.equipment == equipment);
        if (equipment.isAvailable == false)
        {
            rental.user.availableRents++;
            equipment.isAvailable = true;
            rental.isActive = false;
            if (currentDate > rental.returnDate)
            {
                Console.WriteLine("Item was returned late " + equipment.name + " applying fee of " + lateFee + " zl");
                rental.lateFee = lateFee;
            }
            else
            {
                Console.WriteLine("Item was successfully returned: " + equipment.name);
            }
        }
        else
        {
            Console.WriteLine(equipment.name + " is not rented");
        }
    }

    public List<Rental> getActiveRentalsForUser(User user)
    {
        List<Rental> activeRentals = new List<Rental>();
        foreach (Rental rental in rentals)
        {
            if (rental.user == user && rental.isActive == true) 
            {
                
                activeRentals.Add(rental);
            }
        }
        return activeRentals;
    }

    public List<Rental> getAllRentals()
    {
        return rentals;
    }
    
    public List<Rental> getActiveRentals()
    {
        List<Rental> activeRentals = new List<Rental>();
        foreach (Rental rental in rentals)
        {
            if (rental.isActive == true)
                activeRentals.Add(rental);
        }
        return activeRentals;
    }
    
    
        
}