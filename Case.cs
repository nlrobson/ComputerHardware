using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerHardware
{
    class Case
    {
        #region Properties
        public decimal Price { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Serial { get; set; }
        public BoardSize Size { get; set; }
        #endregion

        public override string ToString()
        {
            return $"Price: ${Price}\t Make: {Make}\tModel: {Model}\tSize: {Enum.GetName(typeof(BoardSize),Size)}\tSerial: {Serial}";
        }
    }


}
