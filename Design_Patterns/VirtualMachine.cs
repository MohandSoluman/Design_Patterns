using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
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
}
