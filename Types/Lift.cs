namespace LiftTrackerAPI.Types;

public class Lift
{
    public string Name { get; set; } = string.Empty;
    public int Sets { get; set; }
    public int Reps { get; set; }
    public required Weight LiftWeight { get; set; }

}

public class LiftType : ObjectType<Lift>
{
    protected override void Configure(IObjectTypeDescriptor<Lift> descriptor)
    {
        descriptor
            .Field(f => f.Name)
            .Type<StringType>();

        descriptor
            .Field(f => f.Sets)
            .Type<IntType>();

        descriptor
            .Field(f => f.Reps)
            .Type<IntType>();

        descriptor
            .Field(f => f.LiftWeight)
            .Type<WeightType>();
    }
}