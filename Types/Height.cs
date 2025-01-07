namespace LiftTrackerAPI.Types;

public enum HeightUnit
{
    Centimeters,
    Inches
}

public class Height
{

    public int Val { get; set; }
    public HeightUnit Unit { get; set; }
    
}
