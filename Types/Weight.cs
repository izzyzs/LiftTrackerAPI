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
