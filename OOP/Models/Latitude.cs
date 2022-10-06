using OOP.Models.Common;

namespace OOP.Models
{
    public class Latitude : ValueObject
    {
        public float Value { get; private set; }

        private Latitude() { }

        public Latitude(float value)
        {
            if (value < -90 || value > 90)
            {
                throw new ArgumentOutOfRangeException(nameof(value), value, "Latitude must be in range [-90; 90]");
            }

            this.Value = value;
        }

        public static Latitude FromScalar(float value)
        {
            return new Latitude(value);
        }

        public static implicit operator float(Latitude latitude)
        {
            return latitude.Value;
        }

        public static explicit operator Latitude(float value)
        {
            return new Latitude(value);
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
}
