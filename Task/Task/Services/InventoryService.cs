namespace Task.Services;
using System.Collections.Generic;
using Task.Equipment;

public class InventoryService
{
    static List<Equipment> equipments = new List<Equipment>();

    public void addEquipment(Equipment equipment)
    {
        equipments.Add(equipment);
    }

    public List<Equipment> findAvailableEquipment()
    {
        List<Equipment> availableEquipment = new List<Equipment>();

        foreach (Equipment equipment in equipments)
        {
            if (equipment.isAvailable == true)
            {
                availableEquipment.Add(equipment);
            }
        }

        return availableEquipment;
    }

    public void showAllEquipment()
    {
        foreach (Equipment equipment in equipments)
        {
            if (equipment.isAvailable == true)
                Console.WriteLine(equipment.name + " is available with id: " + equipment.Id);
            else
                Console.WriteLine(equipment.name + " is not available with id: " + equipment.Id);
        }
    }

    public static Equipment findEquipment(int id)
    {
        foreach (Equipment equipment in equipments)
        {
            if (equipment.Id == id)
            {
                return equipment;
            }
        }
        return null;
    }
}