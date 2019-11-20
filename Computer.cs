using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerHardware
{
    class Computer
    {
        public Cpu cpu = new Cpu();
        public Gpu gpu = new Gpu();
        public Memory memory = new Memory();
        public CpuCooler cooler = new CpuCooler();
        public Case computerCase = new Case();
    }
}
