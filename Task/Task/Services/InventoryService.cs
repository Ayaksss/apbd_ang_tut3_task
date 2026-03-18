namespace Task.Services;
using System.Collections.Generic;
using Task.Equipment;

public class InventoryService
{
    List<Equipment> equipments = new List<Equipment>();

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
}