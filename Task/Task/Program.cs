namespace Task.UI;
using Task.Equipment;
using Task.Users;
using Task.Services;

public class Program
{

    
    
   public static void Main()
   {
    InventoryService inventoryService = new InventoryService();
    UserService userService = new UserService();
    RentalService rentalService = new RentalService();
    Equipment testLaptop = new Laptop("MacBook Pro", "Apple", 16);
    Equipment testCamera = new Camera("EOS R5", "Canon", 45);
    Equipment testCamera2 = new Camera("EOS R55", "Canon", 45);
    
    
    inventoryService.addEquipment(testLaptop);
    inventoryService.addEquipment(testCamera);
    inventoryService.addEquipment(testCamera2);

    
    int laptopId = testLaptop.Id;
    int cameraId = testCamera.Id;
    int cameraId2 = testCamera2.Id;

    
    Console.WriteLine("\nAdding Users");
    Student testStudent = new Student("Anna", "Nowak", 10101, 2);
    Employee testEmployee = new Employee("Jan", "Kowalski", 20202, "IT Support");
    
    userService.addUser(testStudent);
    userService.addUser(testEmployee);

    
    Console.WriteLine("\nCorrect rental");
    rentalService.rentEquipment(testStudent, laptopId, DateTime.Parse("2026-03-01"), 5);
    rentalService.rentEquipment(testStudent, cameraId2, DateTime.Parse("2026-03-10"), 5);

    
    Console.WriteLine("\nInvalid operation (renting unavailable equipment)");
    rentalService.rentEquipment(testEmployee, laptopId, DateTime.Parse("2026-03-02"), 3);

    
    Console.WriteLine("\nReturn completed on time");
    rentalService.returnItem(laptopId, DateTime.Parse("2026-03-04"));

    
    Console.WriteLine("\nDelayed return with penalty");
    rentalService.rentEquipment(testEmployee, cameraId, DateTime.Parse("2026-03-01"), 2);
    
    
    rentalService.returnItem(cameraId, DateTime.Parse("2026-03-10"));

    
    Console.WriteLine("\nFinal system state report");
    Console.WriteLine("Currently Available Equipment:");
    
    inventoryService.showAllEquipment();

    foreach (Rental rental in rentalService.getActiveRentals())
    {
        Console.WriteLine(rental.user.firstName + " " + rental.user.lastName + " is renting " + rental.equipment.name);
    }

    double totalFee = 0.0;
    foreach (Rental rental in rentalService.getAllRentals())
    {
        totalFee += rental.lateFee;
    }
    Console.WriteLine("Total fee: " + totalFee);
    }
}
