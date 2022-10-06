namespace OOP.Models;

public class Location
{
    public int Id { get; set; }
    public Longitude Longitude { get; private set; }
    public Latitude Latitude { get; private set; }

    private Location() { }

    public Location(Latitude latitude, Longitude longitude)
    {
        Latitude = latitude;
        Longitude = longitude;
    }
}