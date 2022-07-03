
using Airline.Planes;

namespace Airline.Factories
{
    public class Company
    {
        public string Name { get; set; } = "Belavia";
        
        public Plane FactoryMethod(string type, string name, int capacity, int carrying, int fuelConsumption, int range)
        {
            return type switch
            {
                "WarPlane" => new WarPlane(type, name, capacity, carrying, fuelConsumption, range),
                "CivilPlane" => new CivilPlane(type, name, capacity, carrying, fuelConsumption, range),
                "CargoPlane" => new CargoPlane(type, name, capacity, carrying, fuelConsumption, range),
                _ => throw new Exception("File contains incorrect type of plane")
            };
        }
    }
}
