using Airline.Factories;

namespace Airline.Planes
{
    public abstract class Plane
    {
        public string? Type { get; set; }
        public string? Name { get; set; }
        public int Capacity { get; set; }
        public int Carrying { get; set; }
        public int FuelConsumption { get; set; }
        public int Range { get; set; }
    }
}
