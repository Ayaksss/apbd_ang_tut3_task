namespace Task.Equipment;

public class Camera : Equipment
{
    public String videoResolution { get; set; }
    public int framesPerSecond { get; set; }

    public Camera(String name, String videoResolution, int framesPerSecond) : base(name)
    {
        this.videoResolution = videoResolution;
        this.framesPerSecond = framesPerSecond;
    }
}