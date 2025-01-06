namespace LiftTrackerAPI.Types;

public enum WeightUnit
{
    Pounds,
    Kilograms
}

public class WeightUnitType : EnumType<WeightUnit>
{
}



public class Weight
{
    public int Val { get; set; }
    public WeightUnit Unit { get; set; } = WeightUnit.Pounds;
}

public class WeightType : ObjectType<Weight>
{
    protected override void Configure(IObjectTypeDescriptor<Weight> descriptor)
    {
        descriptor
            .Field(f => f.Val)
            .Type<IntType>();

        descriptor
            .Field(f => f.Unit)
            .Type<EnumType>();
    }
}