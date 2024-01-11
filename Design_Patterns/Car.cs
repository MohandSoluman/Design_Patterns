namespace BuilderPattern;

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