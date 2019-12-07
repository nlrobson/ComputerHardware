using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerHardware
{
    class Computer
    {
        private bool set = false;
        
        public Cpu Cpu { get; private set; }// = new Cpu();
        public Gpu Gpu { get; private set; }
        public Memory Memory { get; private set; }
        public CpuCooler Cooler { get; private set; }
        public MotherBoard MotherBoard { get; private set; }
        public Case ComputerCase { get; private set; }
        public Psu Psu { get; private set; }
        public DateTime CreateDate { get; private set; }
        public string Notes { get; set; }
        

        public Computer()
        {
            CreateDate = DateTime.Now;
        }

        public Computer(Cpu cpu, Gpu gpu, Memory memory, CpuCooler cooler, MotherBoard motherBoard,  Psu psu,Case computerCase)
        {
            Cpu = cpu;
            Gpu = gpu;
            Memory = memory;
            Cooler = cooler;
            MotherBoard = motherBoard;
            Psu = Psu;
            ComputerCase = computerCase;
            CreateDate = DateTime.Now;
        }

        public Computer(string notes)
        {
            Notes = notes;
        }

        public Computer(Computer computer)
        {
            Cpu = computer.Cpu;
            Gpu = computer.Gpu;
            Memory = computer.Memory;
            Cooler = computer.Cooler;
            MotherBoard = computer.MotherBoard;
            ComputerCase = computer.ComputerCase;
            Psu = computer.Psu;
            CreateDate = DateTime.Now;
        }
    }
}
