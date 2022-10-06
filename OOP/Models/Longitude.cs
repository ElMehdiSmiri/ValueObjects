using OOP.Models.Common;

namespace OOP.Models;

public class Longitude : ValueObject
{
    public float Value { get; private set; }

    private Longitude() { }

    public Longitude(float value)
    {
        if (value < -180 || value > 180)
        {
            throw new ArgumentOutOfRangeException(nameof(value), value, "Longitude must be in range [-180; 180]");
        }

        this.Value = value;
    }

    public static Longitude FromScalar(float value)
    {
        return new Longitude(value);
    }

    public static implicit operator float(Longitude longitude)
    {
        return longitude.Value;
    }

    public static explicit operator Longitude(float value)
    {
        return new Longitude(value);
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString()
    {
        return Value.ToString();
    }
}
