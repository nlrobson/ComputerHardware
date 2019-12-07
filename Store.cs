using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerHardware
{
    class Store
    {
        private Inventory inventory;
        public UserAccount CreateAccount(string accountName, string emailAddress, Computer computer)
        {
            var account = new UserAccount
            {
                AccountName = accountName,
                EmailAddress = emailAddress
            };
            if (computer != null)
            {
                account.Order.Add(computer);
            }

            return account;
        }

        public void CreateInventory(Cpu cpu, CpuCooler cooler, Gpu gpu, Memory memory, MotherBoard motherboard, Case computerCase, Psu psu)
        {
            inventory.AddCpu(cpu);
            inventory.AddCooler(cooler);
            inventory.AddGpu(gpu);
            inventory.AddMemory(memory);
            inventory.AddMotherboard(motherboard);
            inventory.AddCase(computerCase);
            inventory.AddPsu(psu);
        }

        public void CreateInventory(List<Cpu> cpu, List<CpuCooler> cooler, List<Gpu> gpu, List<Memory> memory, List<MotherBoard> motherboard, List<Case> computerCase, List<Psu> psu)
        {
            inventory.AddCpu(cpu);
            inventory.AddCooler(cooler);
            inventory.AddGpu(gpu);
            inventory.AddMemory(memory);
            inventory.AddMotherboard(motherboard);
            inventory.AddCase(computerCase);
            inventory.AddPsu(psu);
        }
    }
}
