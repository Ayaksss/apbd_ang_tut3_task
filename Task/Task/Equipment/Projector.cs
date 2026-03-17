namespace Task.Models;

public class Projector : Equipment
{
    public String resolution{set;get;}
    public int brightnessLumens{set;get;}

    public Projector(String resolution, int brightnessLumens)
    {
        this.resolution = resolution;
        this.brightnessLumens = brightnessLumens;
    }
}