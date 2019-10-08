using System;

namespace ComputerHardware
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer computer = new Computer();
            computer.cpu.Make = "AMD";
            computer.cpu.Model = "1700x";
            computer.gpu.Make = "ASUS";
            computer.gpu.Model = "GTX 1070 STRIX";
        }
    }
}
