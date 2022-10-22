using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace FirstTask {
class Printer
{
    public void Print(string value)
    {
        Console.ForegroundColor = color;
        Console.WriteLine(value);
    }
        protected ConsoleColor color = Console.ForegroundColor;
    }

    class Company : Printer
    {
    public Company()
    {
        color = ConsoleColor.Blue;
    }
    }

    class Name : Printer
    {
    public Name()
    {
        color = ConsoleColor.Green;
    }
    }

    class OperatingSystem : Printer
    {
    public OperatingSystem()
    {
        color = ConsoleColor.Yellow;
    }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Company, Name, Operating System:");
            Printer company = new Company();
            company.Print("iPhone");
            Printer name = new Name();
            name.Print("Apple");
            Printer os = new OperatingSystem();
            os.Print("IOS");
            Console.ReadLine();

        }
    }
}



