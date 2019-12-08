using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerHardware
{
    class Memory
    {
        #region Properties
        public string Make { get; set; }
        public string Model { get; set; }
        public string Serial { get; set; }
        public decimal Frequency { get; set; }
        public decimal Price { get; set; }
        #endregion

        public override string ToString()
        {
            return $"Price: ${Price}\t Make: {Make}\tModel: {Model}\tFrequencey: {Frequency}MHz\tSerial: {Serial}";
        }
    }
}
