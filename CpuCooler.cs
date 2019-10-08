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
        public DateTime PurchaseDate { get; set; }
        public CoolerType Type { get; set; }
        public CpuSocket Socket { get; set; }
        #endregion

    }

    enum CoolerType
    {
        Air,
        AIO
    }

    enum CpuSocket
    {
        AM4,
        AM3,
        AM2,
        FM3,
        FM2,
        TR4,
        LGA2066,
        LGA1151,
        LGA1150
    }
}
