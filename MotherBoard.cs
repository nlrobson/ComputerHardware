using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerHardware
{
    class MotherBoard
    {
        public Brand Brand { get; set; }
        public decimal Price { get; set; }
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
