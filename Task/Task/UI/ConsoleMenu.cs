namespace Task.UI;
using Task.Equipment;
using Task.Users;
using Task.Services;

public class ConsoleMenu
{
    InventoryService inventoryService = new InventoryService();
    UserService userService = new UserService();
    RentalService rentalService = new RentalService();
    FeedDatabaseService feedDatabaseService = new FeedDatabaseService();
    
    
    public void main()
    {
        feedDatabaseService.FeedDatabase(userService, inventoryService);
        while (true)
        {
            Console.WriteLine("Welcome to the console menu");
            Console.WriteLine("1 - Available equipments");
            Console.WriteLine("2 - Rent equipment");
            Console.WriteLine("3 - Return equipment");
            Console.WriteLine("4 - Exit");
            Console.Write("> ");
            
            String choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write(inventoryService.findAvailableEquipment().Count);
                    foreach (Equipment equipment in inventoryService.findAvailableEquipment())
                    {
                        Console.WriteLine(equipment);
                    }
                    break;
                case "2":
                    User user;
                    Console.Write("Who are you, (1) Employee. (2) Student: ");
                    choice = Console.ReadLine();
                    Console.Write("First name: ");
                    String FirstName = Console.ReadLine();
                    Console.Write("Last name: ");
                    String LastName = Console.ReadLine();
                    if (choice == "1")
                    {
                        Console.Write("Employee number: ");
                        int EmployeeNumber = Int32.Parse(Console.ReadLine());
                        Console.Write("Your job title: ");
                        String JobTitle = Console.ReadLine();
                        user = new Employee(FirstName, LastName, EmployeeNumber, JobTitle);
                    }
                    else if (choice == "2")
                    {
                        Console.Write("Student number: ");
                        int StudentNumber = Int32.Parse(Console.ReadLine());
                        Console.Write("Your academic year: ");
                        int AcademicYear = Int32.Parse(Console.ReadLine());
                        user = new Student(FirstName, LastName, StudentNumber, AcademicYear);
                    }
                    else
                    {
                        Console.Write("Wrong choice");
                    }
                    break;
                default:
                    break;
                
            }
        }
        
    }
}