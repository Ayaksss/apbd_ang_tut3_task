namespace Task.Equipment;

public class Laptop : Equipment
{
    public String operatingSystem{set;get;} 
    public int ramInGB{set;get;}
    
    public Laptop(String name, String operatingSystem, int ramInGb) : base(name)
        {
            this.operatingSystem = operatingSystem;
            this.ramInGB = ramInGb;
        }
}