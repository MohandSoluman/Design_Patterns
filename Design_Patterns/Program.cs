
namespace BuilderPattern;
public class Computer
{
    public string CPU { get; } = string.Empty;
    public string RAM { get; } = string.Empty;
    public string Storage { get; } = string.Empty;
    public string MakAddress { get; } = string.Empty;
    public bool GraphicsCard { get; }
    public bool SoundCard { get; }
    private Computer(string cPU, string rAM, string storage, string makAddress, bool graphicsCard, bool soundCard)
    {
        CPU = cPU;
        RAM = rAM;
        Storage = storage;
        MakAddress = makAddress;
        GraphicsCard = graphicsCard;
        SoundCard = soundCard;
    }
    public class Builder
    {
        private string cpu = string.Empty;
        private string ram = string.Empty;
        private string storage = string.Empty;
        private string makAddress = string.Empty;
        private bool graphicsCard;
        private bool soundCard;
        public Builder SetCpu(string value)
        {
            cpu = value;
            return this;
        }
        public Builder SetRam(string value)
        {
            ram = value;
            return this;
        }
        public Builder SetStorage(string value)
        {
            storage = value;
            return this;
        }
        public Builder SetMakAddress(string value)
        {
            makAddress = value;
            return this;
        }
        public Builder SetGraphicsCard(bool value)
        {
            graphicsCard = value;
            return this;
        }
        public Builder SetSoundCard(bool value)
        {
            soundCard = value;
            return this;
        }
        public Computer Build()
        {
            return new Computer(cpu, ram, storage, makAddress, graphicsCard, soundCard);
        }

    }
}
public class Car
{
    public string Model { get; } = string.Empty;
    public string Color { get; } = string.Empty;
    public int Horsepower { get; }
    public bool GPSNavigation { get; }
    public bool Sunroof { get; }

    private Car(string model, string color, int horsePower, bool gPSNavigation, bool sunroof)
    {
        Model = model;
        Color = color;
        Horsepower = horsePower;
        GPSNavigation = gPSNavigation;
        Sunroof = sunroof;

    }

    public class Builder
    {
        private string model = string.Empty;
        private string color = string.Empty;
        private int horsepower;
        private bool gPSNavigation;
        private bool sunroof;

        public Builder SetModel(string value)
        {
            model = value;
            return this;
        }
        public Builder SetColor(string value)
        {
            color = value;
            return this;
        }
        public Builder SetHorsepower(int value)
        {
            horsepower = value;
            return this;
        }
        public Builder SetGPSNavigation(bool value)
        {
            gPSNavigation = value;
            return this;
        }
        public Builder SetSunroof(bool value)
        {
            sunroof = value;
            return this;
        }
        public Car Build()
        {
            return new Car(model, color, horsepower, gPSNavigation, sunroof);
        }
    }

}
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
public class VirtualMachine
{
    // Mandatory configurations
    public string OperatingSystem { get; }
    public int CPU { get; }
    public int RAM { get; }
    public string Storage { get; }

    // Optional configurations with default values
    public string NetworkConfiguration { get; private set; } = "Default";
    public bool EnableBackup { get; private set; } = false;
    public bool EnableMonitoring { get; private set; } = false;
    public bool EnableFirewall { get; private set; } = false;

    // Private constructor for immutability
    private VirtualMachine(string operatingSystem, int cpu, int ram, string storage)
    {
        OperatingSystem = operatingSystem;
        CPU = cpu;
        RAM = ram;
        Storage = storage;
    }

    // Builder class
    public class Builder
    {
        private string operatingSystem = string.Empty;
        private int cpu;
        private int ram;
        private string storage = string.Empty;

        // Optional configurations with default values
        private string networkConfiguration = "Default";
        private bool enableBackup = false;
        private bool enableMonitoring = false;
        private bool enableFirewall = false;

        public Builder SetOperatingSystem(string value)
        {
            operatingSystem = value;
            return this;
        }

        public Builder SetCPU(int value)
        {
            cpu = value;
            return this;
        }

        public Builder SetRAM(int value)
        {
            ram = value;
            return this;
        }

        public Builder SetStorage(string value)
        {
            storage = value;
            return this;
        }

        public Builder SetNetworkConfiguration(string value)
        {
            networkConfiguration = value;
            return this;
        }

        public Builder EnableBackup()
        {
            enableBackup = true;
            return this;
        }

        public Builder EnableMonitoring()
        {
            enableMonitoring = true;
            return this;
        }

        public Builder EnableFirewall()
        {
            enableFirewall = true;
            return this;
        }

        public VirtualMachine Build()
        {
            return new VirtualMachine(operatingSystem, cpu, ram, storage)
            {
                NetworkConfiguration = networkConfiguration,
                EnableBackup = enableBackup,
                EnableMonitoring = enableMonitoring,
                EnableFirewall = enableFirewall
            };
        }
    }
}
public class OnlineOrder
{
    public List<string> Items { get; }
    public string ShippingAddress { get; }
    public decimal TotalAmount { get; }
    public decimal DiscountAmount { get; }

    // Private constructor for immutability
    private OnlineOrder(List<string> items, string shippingAddress, decimal totalAmount, decimal discountAmount)
    {
        Items = items;
        ShippingAddress = shippingAddress;
        TotalAmount = totalAmount;
        DiscountAmount = discountAmount;
    }

    // Builder class
    public class Builder
    {
        private List<string> items = new List<string>();
        private string shippingAddress = string.Empty;
        private decimal totalAmount;
        private decimal discountAmount;

        public Builder AddItem(string item)
        {
            items.Add(item);
            return this;
        }

        public Builder SetShippingAddress(string address)
        {
            shippingAddress = address;
            return this;
        }

        public Builder SetTotalAmount(decimal amount)
        {
            totalAmount = amount;
            return this;
        }

        public Builder ApplyDiscount(decimal discount)
        {
            discountAmount = discount;
            return this;
        }

        public OnlineOrder Build()
        {
            // Perform any additional logic or validation if needed before creating the OnlineOrder object
            // For example, calculate the total amount based on items and apply discounts.

            // Simulating some logic to calculate the total amount and apply discount
            decimal calculatedTotal = CalculateTotalAmount(items);
            decimal calculatedDiscount = CalculateDiscount(calculatedTotal, discountAmount);

            return new OnlineOrder(items, shippingAddress, calculatedTotal, calculatedDiscount);
        }

        private decimal CalculateTotalAmount(List<string> items)
        {
            // Simulated logic to calculate the total amount based on items
            return items.Count * 10.0m; // Assuming each item costs $10
        }

        private decimal CalculateDiscount(decimal totalAmount, decimal discountAmount)
        {
            // Simulated logic to apply discount
            return Math.Min(totalAmount, discountAmount);
        }
    }
}

public class Program
{
    public static void Main()
    {


        // -------------------------------------------
        // 1-Complex Object Construction:dd
        //------------------------------------------
        /*
         Creational Design Pattern: This means the pattern deals with object creation mechanisms,
         trying to create objects in a manner suitable to the situation.
         In simpler terms, it helps in creating objects effectively.
        
            -- normal-Way
                Create computer without using the builder pattern
                Involves creating an instance of the Computer class 
                and setting properties individually.
                Hard to remember the order and types of configurations.
                Prone to mistakes, especially with optional configurations.

         -- With Builder Pattern
          Create computer  using the builder pattern

           Provides a fluent and readable syntax for configuring the Computer object.
           Each configuration method returns the builder instance, allowing for method chaining.
           Optional configurations can be set more clearly and without relying on the order
           of property assignments.

        */

        Computer myComputer1 = new Computer.Builder()
            .SetMakAddress("452-25")
            .SetCpu("Intel Core i7")
            .SetSoundCard(true)
            .SetRam("16GB")
            .SetGraphicsCard(true)
            .Build();


        _ = new Car.Builder()
            .SetColor("black")
            .SetHorsepower(1500)
            .SetModel("de-20")
            .SetGPSNavigation(true)
            .Build();

        // -------------------------------------------
        // 2 - Creating a Vehicle with Different Representations
        //------------------------------------------
        Vehicle motorcycle = new Vehicle.MotorcycleBuilder()
            .SetBrand("Harley-Davidson")
            .SetModel("Sportster")
            .SetYear(2021)
            .SetFuelType("Petrol")
            .Build();

        Vehicle truck = new Vehicle.TruckBuilder()
            .SetBrand("Ford")
            .SetModel("F-150")
            .SetYear(2020)
            .SetFuelType("Diesel")
            .Build();

        //--------------------------------------------------------
        // 3 - object with a large number of configuration options
        //----------------------------------------------------------
        VirtualMachine virtualMachine = new VirtualMachine.Builder()
            .SetOperatingSystem("Linux")
            .SetCPU(4)
            .SetRAM(16)
            .SetStorage("500GB SSD")
            .SetNetworkConfiguration("Custom VLAN")
            .EnableBackup()
            .EnableMonitoring()
            .Build();

        //-------------------------------------------------------------------------
        // 4 - OnlineOrder class representing the step-by-step constructed object
        //-------------------------------------------------------------------------
        OnlineOrder order = new OnlineOrder.Builder()
            .AddItem("Product A")
            .AddItem("Product B")
            .SetShippingAddress("123 Main St, City")
            .SetTotalAmount(25.0m)
            .ApplyDiscount(5.0m)
            .Build();



    }
}

