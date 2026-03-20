namespace Task.Services;
using Task.Equipment;
using Task.Users;


public class FeedDatabaseService
{
    
    public void FeedDatabase(UserService userService, InventoryService inventoryService)
    {
        userService.addUser(new Student("John", "Doe", 12345, 1));
        userService.addUser(new Employee("Jane", "Smith", 13241, "Manager"));

        inventoryService.addEquipment(new Laptop("MacBook", "MacOS", 16));
        inventoryService.addEquipment(new Camera("EOS Rebel", "4k", 120));
    }
    
}