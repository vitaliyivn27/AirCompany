using Airline.Factories;
using Airline.Planes;


namespace Airline
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("                             Aircompany Belavia\n                                List of planes");
            List<Plane> planes = new List<Plane>();
            TakeValuesFromFile(planes);
            Console.WriteLine("General form: 1 - Type, 2 - Name, 3 - Capacity, 4 - Carrying, 5 - FuelConsumption, 6 - Range\n");
            List <Plane> SortedList = planes.OrderBy(o => o.Range).ToList();

            foreach (Plane plane in SortedList)
            {
                Console.WriteLine($"{plane.Type}   -   {plane.Name}   -   {plane.Capacity}   -   {plane.Carrying}   -   {plane.FuelConsumption}   -   {plane.Range}");
            }

            Console.WriteLine("\nWrite 2 numbers for fuel consumption range\n Write first int less number");
            bool isNumber1 = int.TryParse(Console.ReadLine(), out var firstNumber);
            Console.WriteLine("Write second int more number");
            bool isNumber2 = int.TryParse(Console.ReadLine(), out var secondNumber);
            Console.WriteLine("Planes included in the range or blunk field if none in the range:");
            if (isNumber1 && isNumber2 && firstNumber <= secondNumber)
            {
                foreach (Plane plane in SortedList)
                {
                    if (plane.FuelConsumption >= firstNumber && plane.FuelConsumption <= secondNumber)
                    {
                        Console.WriteLine($"{plane.Type}   -   {plane.Name}   -   {plane.Capacity}   -   {plane.Carrying}   -   {plane.FuelConsumption}   -   {plane.Range}");
                    }
                }
            }
            else
            {
                Console.WriteLine("Incorrect input");
            }           
        }
        static void TakeValuesFromFile(List<Plane> list)
        {
            string path = "Airplanes.txt";
            using (StreamReader reader = new StreamReader(path))
            {
                var i = 0;
                try
                {
                    int commonCapacity = 0;
                    int commonCarrying = 0;
                    do
                    {
                        string? line = reader.ReadLine();
                        string[] values = line.Split(' ');
                        string type = values[0];
                        string name = values[1];
                        bool isOk = int.TryParse(values[2], out int capacity);
                        bool isOk2 = int.TryParse(values[3], out int carrying);
                        bool isOk3 = int.TryParse(values[4], out int fuelConsumption);
                        bool isOk4 = int.TryParse(values[5], out int range);
                        Company createdCompany = new Company();
                        var plane = createdCompany.FactoryMethod(type, name, capacity, carrying, fuelConsumption, range);
                        i++;
                        commonCapacity += capacity;
                        commonCarrying += carrying;
                        list.Add(plane);
                    } while (i < 15);
                    Console.WriteLine($"                        Common capacity - {commonCapacity}");
                    Console.WriteLine($"                        Common carrying - {commonCarrying}");
                }
                catch (FormatException)
                {
                    Console.WriteLine("System.FormatException");
                }
                catch (OutOfMemoryException)
                {
                    Console.WriteLine("OutOfMemoryException");
                }
                catch (IOException)
                {
                    Console.WriteLine("IOException");
                }
            }
        }
    }
}