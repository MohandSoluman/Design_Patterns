
namespace BuilderPattern;





public class Program
{
    public static void Main()
    {


        // -------------------------------------------
        // 1-ComplexObject Construction:dd
        //------------------------------------------
      
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

