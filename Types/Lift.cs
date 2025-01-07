namespace LiftTrackerAPI.Types;

public class Lift
{
    public string Name { get; set; } = string.Empty;
    public int Sets { get; set; }
    public int Reps { get; set; }
    public required Weight LiftWeight { get; set; }

}
