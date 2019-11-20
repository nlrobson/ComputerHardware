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
                Console.WriteLine("1. Create a new Computer");
                Console.WriteLine("2. View Current Computer in Process");
                Console.WriteLine("3. Pay and Complete Order");
                Console.WriteLine("4. Receipt");
                Console.WriteLine("5. View Previous Orders");

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

                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                    case "5":
                        break;
                    default:
                        Console.Write("Invalid Choice, Please try again!");
                        break;
                }
            }
        }
    }
}
