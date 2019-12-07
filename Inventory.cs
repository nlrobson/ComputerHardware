using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerHardware
{
    class Inventory
    {
        public List<Cpu> Cpu { get; private set; }
        public List<Gpu> Gpu { get; private set; }
        public List<Memory> Memory { get; private set; }
        public List<CpuCooler> CpuCooler { get; private set; }
        public List<MotherBoard> MotherBoard { get; private set; }
        public List<Case> ComputerCases { get; private set; }
        public List<Psu> Psu { get; private set; }

        public void AddCpu(Cpu cpu)
        {
            Cpu.Add(cpu);
        }
        public void AddCpu(List<Cpu> cpu)
        {
            foreach(Cpu c in cpu)
            {
                Cpu.Add(c);
            }
        }

        public void AddGpu(Gpu gpu)
        {
            Gpu.Add(gpu);
        }
        public void AddGpu(List<Gpu> gpu)
        {
            foreach (Gpu g in gpu)
            {
                Gpu.Add(g);
            }
        }

        public void AddMemory(Memory memory)
        {
            Memory.Add(memory);
        }
        public void AddMemory(List<Memory> memory)
        {
            foreach (Memory m in memory)
            {
                Memory.Add(m);
            }
        }

        public void AddCooler(CpuCooler cooler)
        {
            CpuCooler.Add(cooler);
        }
        public void AddCooler(List<CpuCooler> cooler)
        {
            foreach (CpuCooler c in cooler)
            {
                CpuCooler.Add(c);
            }
        }

        public void AddMotherboard(MotherBoard motherboard)
        {
            MotherBoard.Add(motherboard);
        }
        public void AddMotherboard(List<MotherBoard> motherboard)
        {
            foreach (MotherBoard m in motherboard)
            {
                MotherBoard.Add(m);
            }
        }

        public void AddCase(Case computerCase)
        {
            ComputerCases.Add(computerCase);
        }
        public void AddCase(List<Case> computerCase)
        {
            foreach (Case c in computerCase)
            {
                ComputerCases.Add(c);
            }
        }

        public void AddPsu(Psu psu)
        {
            Psu.Add(psu);
        }
        public void AddPsu(List<Psu> psu)
        {
            foreach (Psu p in psu)
            {
                Psu.Add(p);
            }
        }
    }
}
