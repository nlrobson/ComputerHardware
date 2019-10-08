using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerHardware
{
    class Gpu
    {
        #region Properties
        public decimal Price { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Serial { get; set; }
        public DateTime PurchaseDate { get; set; }
        public decimal CoreFrequency { get; set; }
        public decimal MemoryFrequency { get; set; }
        #endregion
    }
}
