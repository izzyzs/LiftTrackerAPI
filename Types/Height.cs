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

public class HeightType : ObjectType<Height>
{
    protected override void Configure(IObjectTypeDescriptor<Height> descriptor)
    {
        descriptor
            .Field(f => f.Val)
            .Type<IntType>();

        descriptor
            .Field(f => f.Unit)
            .Type<EnumType>();
    }
}