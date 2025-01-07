namespace LiftTrackerAPI.Types;

public class User
{
    public int Id { get; set; }
    public string Username { get; set; } = string.Empty;
    public Weight? UserWeight { get; set; }
    public Height? UserHeight { get; set; }
    public List<Lift> Lifts { get; set; } = [];
}
