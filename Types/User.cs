namespace LiftTrackerAPI.Types;

public class User
{
    public int Id { get; set; }
    public string Username { get; set; } = string.Empty;
    public Weight? UserWeight { get; set; }
    public Height? UserHeight { get; set; }
    public List<Lift> Lifts { get; set; } = [];
}

public class UserType: ObjectType<User>
{
    protected override void Configure(IObjectTypeDescriptor<User> descriptor)
    {
        descriptor
            .Field(f => f.Id)
            .Type<IntType>();
        
        descriptor
            .Field(f => f.Username)
            .Type<StringType>();
        
        descriptor
            .Field(f => f.UserWeight)
            .Type<WeightType>();

        descriptor
            .Field(f => f.UserHeight)
            .Type<HeightType>();
        
        descriptor
            .Field(f => f.Lifts)
            .Type<ListType<LiftType>>();
    }
}