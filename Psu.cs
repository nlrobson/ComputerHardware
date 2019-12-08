using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerHardware
{
    class Psu
    { 
     #region Properties
    public decimal Price { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public string Serial { get; set; }
    public int Watts { get; set; }
        #endregion

        public override string ToString()
        {
            return $"Price: ${Price}\t Make: ${Make}\tModel: {Model}\tWatts: {Watts}\tSerial: {Serial}";
        }
    }
}
