using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComputerHardware
{
    class Store
    {
        private static Inventory inventory;
        private static List<UserAccount> accounts = new List<UserAccount>();
        public static UserAccount CreateAccount(string accountName, string emailAddress, Computer computer)
        {
            var account = new UserAccount
            {
                AccountName = accountName,
                EmailAddress = emailAddress
            };
            if (computer != null)
            {
                account.AddComputer(computer);
            }

            return account;
        }

        public static IEnumerable<UserAccount> GetAllAccountsByEmailAddress(string emailAddress)
        {
            return accounts.Where(a => a.EmailAddress == emailAddress);
        }

        public static void CreateInventory(Cpu cpu, CpuCooler cooler, Gpu gpu, Memory memory, MotherBoard motherboard, Case computerCase, Psu psu)
        {
            inventory.AddCpu(cpu);
            inventory.AddCooler(cooler);
            inventory.AddGpu(gpu);
            inventory.AddMemory(memory);
            inventory.AddMotherboard(motherboard);
            inventory.AddCase(computerCase);
            inventory.AddPsu(psu);
        }

        public static void CreateInventory(List<Cpu> cpu, List<CpuCooler> cooler, List<Gpu> gpu, List<Memory> memory, List<MotherBoard> motherboard, List<Case> computerCase, List<Psu> psu)
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
