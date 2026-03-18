namespace Task.Equipment;

public class Camera : Equipment
{
    public int videoResolution { get; set; }
    public int framesPerSecond { get; set; }
    
    public Camera(int videoResolution, int framesPerSecond)
    {
        this.videoResolution = videoResolution;
        this.framesPerSecond = framesPerSecond;
    }
}