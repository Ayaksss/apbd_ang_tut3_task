namespace Task.Services;
using Task.Users;
using Task.Equipment;

public class RentalService
{
    List<Rental> rentals = new List<Rental>();

    public void rentEquipment(User user, int equipmentId)
    {
        Equipment equipment = InventoryService.findEquipment(equipmentId);
        if (equipment.isAvailable == true)
        {
            rentals.Add(new Rental(user, equipment));    
            equipment.isAvailable = false;
        }
    }
    public void returnItem(Equipment equipment)
    {
        if (equipment.isAvailable == false)
        {
            rentals.Remove(rentals.Find(x => x.equipment == equipment));
            equipment.isAvailable = true;
        }
        else
        {
            Console.WriteLine(equipment + " is not rented");
        }
    }
}