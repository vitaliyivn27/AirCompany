
namespace Airline.Planes
{
    public class CargoPlane : Plane
    {
        public CargoPlane(string type, string name, int capacity, int carrying, int fuelConsumption, int range)
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
