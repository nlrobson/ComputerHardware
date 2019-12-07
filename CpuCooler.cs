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

    }

    enum CoolerType
    {
        Air,
        AIO
    }
}
