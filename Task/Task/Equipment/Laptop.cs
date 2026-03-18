namespace Task.Equipment;

public class Laptop : Equipment
{
    public String operatingSystem{set;get;} 
    public int ramInGB{set;get;}
    
    public Laptop(String operatingSystem, int ramInGb)
        {
            this.operatingSystem = operatingSystem;
            this.ramInGB = ramInGb;
        }
}