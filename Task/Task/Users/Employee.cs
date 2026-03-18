namespace Task.Users;

public class Employee : User
{
    public int employeeNumber { get; set; }
    public String jobTitle { get; set; }

    public Employee(String firstName, String lastName, int employeeNumber, string jobTitle) : base(firstName, lastName)
    {
        this.jobTitle = jobTitle;
        this.employeeNumber = employeeNumber;
    }
}