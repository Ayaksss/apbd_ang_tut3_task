namespace Task.Users;

public abstract class User
{
    private static int next_Id = 1;
    
    public int Id { get; private set; }
    
    public String firstName{get;set;}
    public String lastName{get;set;}
    
    public String userType{get;set;}

    protected User(String firstName, String lastName)
    {
        Id = next_Id++;
        this.firstName = firstName;
        this.lastName = lastName;
    }
}