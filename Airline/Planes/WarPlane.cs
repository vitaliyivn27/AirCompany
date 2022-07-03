
namespace Airline.Planes
{
    public class WarPlane : Plane
    {
        public WarPlane(string type, string name, int capacity, int carrying, int fuelConsumption, int range)
        {
            Type = type;
            Name = name;
            Capacity = capacity;
            Carrying = carrying;
            FuelConsumption = fuelConsumption;
            Range = range;
        }
    }
}
