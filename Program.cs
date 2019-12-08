using System;

namespace ComputerHardware
{
    class Program
    {
        static void Main(string[] args)
        {
            //Computer computer = new Computer();
            //computer.cpu.Make = "AMD";
            //computer.cpu.Model = "1700x";
            //computer.gpu.Make = "ASUS";
            //computer.gpu.Model = "GTX 1070 STRIX";

            Console.WriteLine("***** Welcome to Computer Order Generator *****");

            while (true)
            {
                Console.WriteLine("0. Exit");
                Console.WriteLine("1. Create a new Account");
                Console.WriteLine("2. Create a new Computer");
                Console.WriteLine("3. View Current Computer in Process");
                Console.WriteLine("4. Pay and Complete Order");
                Console.WriteLine("5. Receipt");
                Console.WriteLine("6. View Previous Orders");

                var option = Console.ReadLine();

                switch (option)
                {
                    case "0":
                        Console.WriteLine("Thank you for visiting the Compter Order Generator!");
                        return;
                    case "1":
                        Console.Write("Email Address:");
                        var email = Console.ReadLine();
                        Console.Write("Account Name:");
                        var name = Console.ReadLine();
                        Cpu cpu = new Cpu()
                        {
                            Price = 250,
                            Make = CpuMake.AMD,
                            Model = "3700x",
                            Frequency = 3.80M,
                            Socket = CpuSocket.AM4
                        };
                        Gpu gpu = new Gpu()
                        {
                            Price = 450,
                            Make = GpuMake.AMD,
                            Model = "5700xt",
                            Serial = "A01-G32-078",
                            CoreFrequency = 1650M,
                            MemoryFrequency = 1905M
                        };
                        Memory memory = new Memory()
                        {
                            Make = "Corsair",
                            Model = "Vengeance",
                            Serial = "14876a2s5",
                            Frequency = 3200M
                        };
                        MotherBoard motherboard = new MotherBoard()
                        {
                            Make = Brand.MSI,
                            Size = BoardSize.ATX,
                            Model = "Creator",
                            Price = 530M,
                            Serial = "1a5e2f66645e"
                        };
                        CpuCooler cooler = new CpuCooler()
                        {
                            Price = 100.00M,
                            Make = "Corsair",
                            Model = "H100i",
                            Serial = "1JI198937dch",
                            Type = CoolerType.AIO,
                            Socket = CpuSocket.AM4
                        };
                        Case computerCase = new Case()
                        {
                            Price = 120.00M,
                            Make = "Corsair",
                            Model = "Carbide",
                            Serial = "123asdf8",
                            Size = BoardSize.ATX
                        };
                        Psu psu = new Psu()
                        {
                            Price = 75.00M,
                            Make = "Corsair",
                            Model = "RM850x",
                            Serial = "12s4f86w",
                            Watts = 850
                        };
                        Computer computer = new Computer(cpu, gpu, memory, cooler, motherboard, psu, computerCase);
                        var account = Store.CreateAccount(name, email, computer);
                        Console.WriteLine($"AccountName: {account.AccountName}, Email: {account.EmailAddress} has been created.");
                        if (computer != null)
                        {
                            Console.WriteLine($"A computer has been ordered as follows:\n{computer}");
                        }
                        break;
                    case "2":
                        Console.Write("Email Address: ");
                        email = Console.ReadLine();

                        var accounts = Store.GetAllAccountsByEmailAddress(email);
                        foreach(var a in accounts)
                        {
                            Console.WriteLine($"AccountName: {a.AccountName}, Email: {a.EmailAddress} has been created.");
                        }
                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                    case "5":
                        break;
                    case "6":
                        break;
                    default:
                        Console.Write("Invalid Choice, Please try again!");
                        break;
                }
            }
        }
    }
}
