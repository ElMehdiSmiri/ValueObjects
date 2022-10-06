using OOP.Models;

namespace OOP.DTOs.Extensions
{
    public static class LocationExtensions
    {
        public static LocationDto Map(this Location value)
        {
            return new LocationDto
            {
                Id = value.Id,
                Latitude = value.Latitude,
                Longitude = value.Longitude
            };
        }

        public static Location Map(this LocationDto value)
        {
            return new Location((Latitude)value.Latitude, (Longitude)value.Longitude);
        }

        public static Location Map(this LocationCreateEditDto value)
        {
            return new Location((Latitude)value.Latitude, (Longitude)value.Longitude);
        }
    }
}
