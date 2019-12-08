using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerHardware
{
    class CpuCooler
    {
        #region Properties
        public decimal Price { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Serial { get; set; }
        public CoolerType Type { get; set; }
        public CpuSocket Socket { get; set; }
        #endregion

        public override string ToString()
        {
            return $"Price: ${Price}\t Make: {Make}\tModel: {Model}\tType: {Enum.GetName(typeof(CoolerType), Type)}\tSocket: {Enum.GetName(typeof(CpuSocket), Socket)}\tSerial: {Serial}";
        }
    }

    enum CoolerType
    {
        Air,
        AIO
    }
}
