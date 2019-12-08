using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerHardware
{
    class MotherBoard
    {
        public Brand Make { get; set; }
        public BoardSize Size { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
        public string Serial { get; set; }

        public override string ToString()
        {
            return $"Price: ${Price}\t Make: {Make}\tModel: {Model}\tSize: {Enum.GetName(typeof(BoardSize), Size)}\tSerial: {Serial}";
        }
    }

    enum BoardSize
    {
        MiniITX,
        MicroATX,
        ATX

    }

    enum Brand
    {
        AURUS,
        ASUS,
        GIGABITE,
        MSI
    }

}
