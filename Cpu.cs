using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerHardware
{
    class Cpu
    {
        #region Properties
        public decimal Price { get; set; }
        public CpuMake Make { get; set; }
        public string Model { get; set; }
        public string Serial { get; set; }
        public decimal Frequency { get; set; }
        public CpuSocket Socket { get; set; }
        #endregion

        public override string ToString()
        {
            return $"Price: ${Price}\t Make: {Enum.GetName(typeof(CpuMake), Make)}\tModel: {Model}\tFrequency: {Frequency}GHz\tSocket: {Enum.GetName(typeof(CpuSocket), Socket)}\tSerial: {Serial}";
        }
    }

    enum CpuSocket
    {
        AM4,
        TR4,
        LGA2066,
        LGA1151,
        LGA1150
    }
    enum CpuMake
    {
        AMD,
        Intel
    }
}
