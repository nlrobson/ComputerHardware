using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerHardware
{
    class Gpu
    {
        #region Properties
        public decimal Price { get; set; }
        public GpuMake Make { get; set; }
        public string Model { get; set; }
        public string Serial { get; set; }
        public decimal CoreFrequency { get; set; }
        public decimal MemoryFrequency { get; set; }
        #endregion

        public override string ToString()
        {
            return $"Price: ${Price}\t Make: {Enum.GetName(typeof(GpuMake), Make)}\tModel: {Model}\tCore Frequency: {CoreFrequency}MHz\tMemory Frequency: {MemoryFrequency}MHz\tSerial: {Serial}";
        }
    }

    enum GpuMake
    {
        AMD,
        Nvidia
    }
}
