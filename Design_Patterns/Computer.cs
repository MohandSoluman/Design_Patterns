
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

