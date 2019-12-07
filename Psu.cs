using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerHardware
{
    class Psu
    { 
     #region Properties
    public decimal Price { get; set; }
    public string Model { get; set; }
    public string Serial { get; set; }
    public decimal Frequency { get; set; }
    public int Watts { get; set; }
    #endregion
    }
}
