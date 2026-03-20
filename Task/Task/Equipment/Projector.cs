namespace Task.Equipment;

public class Projector : Equipment
{
    public String resolution{set;get;}
    public int brightnessLumens{set;get;}

    public Projector(String name, String resolution, int brightnessLumens) : base(name)
    {
        this.resolution = resolution;
        this.brightnessLumens = brightnessLumens;
    }
}