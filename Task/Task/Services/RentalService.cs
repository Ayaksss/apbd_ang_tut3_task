namespace Task.Services;
using Task.Users;
using Task.Equipment;

public class RentalService
{
    List<Rental> rentals = new List<Rental>();

    public void rentEquipment(User user, Equipment equipment)
    {
        if (equipment.isAvailable == true && user.availableRents > 0)
        {
            rentals.Add(new Rental(user, equipment));    
            equipment.isAvailable = false;
            user.availableRents--;
        }
    }
    public void returnItem(Equipment equipment)
    {
        if (equipment.isAvailable == false)
        {
            //user.availableRents++;
            User user = 
            rentals.Remove(rentals.Find(x => x.equipment == equipment));
            equipment.isAvailable = true;
        }
        else
        {
            Console.WriteLine(equipment + " is not rented");
        }
    }
}