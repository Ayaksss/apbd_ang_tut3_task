namespace Task.Equipment;

public abstract class Equipment
{
    private static int next_Id = 1;
    
    public int Id { get; private set; }
    
    public String name{get;set;}
    public bool isAvailable{get;set;}

    protected  Equipment()
    {
        Id = next_Id++;
    }
}