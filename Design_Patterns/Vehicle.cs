namespace BuilderPattern;
public class Vehicle
{
    public string Type { get; }
    public string Brand { get; }
    public string Model { get; }
    public int Year { get; }
    public string FuelType { get; }


    // Private constructor for immutability
    private Vehicle(string type, string brand, string model, int year, string fuelType)
    {
        Type = type;
        Brand = brand;
        Model = model;
        Year = year;
        FuelType = fuelType;
        // ... initialize other properties
    }

    // Car builder
    public class MotorcycleBuilder
    {
        private string brand = string.Empty;
        private string model = string.Empty;
        private int year;
        private string fuelType = string.Empty;

        public MotorcycleBuilder SetBrand(string value)
        {
            brand = value;
            return this;
        }

        public MotorcycleBuilder SetModel(string value)
        {
            model = value;
            return this;
        }

        public MotorcycleBuilder SetYear(int value)
        {
            year = value;
            return this;
        }

        public MotorcycleBuilder SetFuelType(string value)
        {
            fuelType = value;
            return this;
        }

        public Vehicle Build()
        {
            return new Vehicle("MotorCycl", brand, model, year, fuelType);
        }
    }


    // Truck builder (similar to CarBuilder)
    public class TruckBuilder
    {
        private string brand = string.Empty;
        private string model = string.Empty;
        private int year;
        private string fuelType = string.Empty;

        public TruckBuilder SetBrand(string value)
        {
            brand = value;
            return this;
        }

        public TruckBuilder SetModel(string value)
        {
            model = value;
            return this;
        }

        public TruckBuilder SetYear(int value)
        {
            year = value;
            return this;
        }

        public TruckBuilder SetFuelType(string value)
        {
            fuelType = value;
            return this;
        }

        public Vehicle Build()
        {
            return new Vehicle("MotorCycl", brand, model, year, fuelType);
        }
    }


}