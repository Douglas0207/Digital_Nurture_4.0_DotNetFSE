using System;

namespace BuilderPatternExample
{
    class Computer
    {
        public string CPU { get; private set; } = "Not Specified";
        public string RAM { get; private set; } = "Not Specified";
        public string Storage { get; private set; } = "Not Specified";
        public string GPU { get; private set; } = "Not Specified";
        public string OperatingSystem { get; private set; } = "Not Specified";

        private Computer(Builder builder)
        {
            CPU = builder.CPU;
            RAM = builder.RAM;
            Storage = builder.Storage;
            GPU = builder.GPU;
            OperatingSystem = builder.OperatingSystem;
        }
        public class Builder
        {
            public string CPU;
            public string RAM;
            public string Storage;
            public string GPU;
            public string OperatingSystem;

            public Builder SetCPU(string cpu)
            {
                this.CPU = cpu;
                return this;
            }
            public Builder SetRAM(string ram)
            {
                this.RAM = ram;
                return this;
            }
            public Builder SetStorage(string storage)
            {
                this.Storage = storage;
                return this;
            }
            public Builder SetGPU(string gpu)
            {
                this.GPU = gpu;
                return this;
            }
            public Builder SetOperatingSystem(string os)
            {
                this.OperatingSystem = os;
                return this;
            }
            public Computer Build()
            {
                return new Computer(this);
            }

        }
        public void ShowConfig()
        {
            Console.WriteLine("\nComputer Configuration");
            Console.WriteLine($"CPU: {CPU ?? "Not Specified"}");
            Console.WriteLine($"RAM: {RAM ?? "Not Specified"}");
            Console.WriteLine($"Storage: {Storage ?? "Not Specified"}");
            Console.WriteLine($"GPU: {GPU ?? "Not Specified"}");
            Console.WriteLine($"Operating System: {OperatingSystem ?? "Not Specified"}");

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Computer basicPc = new Computer.Builder().SetCPU("Intel i5")
            .SetRAM("8GB").SetStorage("256GB SSD").Build();
            Computer highSpecPC = new Computer.Builder().SetCPU("Intel i9")
            .SetRAM("32GB").SetStorage("1TB SSD").SetGPU("NVIDIA RTX 4080").SetOperatingSystem("Windows 11pro").Build();
            basicPc.ShowConfig();
            highSpecPC.ShowConfig();
        }
    }
}