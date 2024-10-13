using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleQuestionsAssignment
{
    public class Computer
    {
        public string Processor { get; set; }
        public int RamSize { get; set; }
        public int HardDiskSize { get; set; }
        public int GraphicCard { get; set; }

        public Computer(string processor, int ramSize, int hardDiskSize, int graphicCard)
        {
            Processor = processor;
            RamSize = ramSize;
            HardDiskSize = hardDiskSize;
            GraphicCard = graphicCard;
        }
    }
    public class Desktop : Computer
    {
        public int MonitorSize { get; set; }
        public int PowerSupplyVolt { get; set; }
        double ProcessorPrice;
        public double DesktopPriceCalculation()
        {
            
            if (Processor == "i3")
            {
                 ProcessorPrice = 1500;
            }
            else if (Processor == "i5")
            {
                 ProcessorPrice = 3000;
            }
            else if (Processor == "i7")
            {
                 ProcessorPrice = 4500;
            }
            double RamPrice = 200;
            double HardDiskPrice = 1500;
            double GraphicCardPrice = 2500;
            double PowerSupplyVoltPrice = 20;
            double MonitorPrice = 250;
            double DesktopPrice = ProcessorPrice + (RamSize * RamPrice) + (HardDiskSize * HardDiskPrice) + (GraphicCard * GraphicCardPrice) + (MonitorSize * MonitorPrice) + (PowerSupplyVolt * PowerSupplyVoltPrice);
            return DesktopPrice;
        }
        public Desktop(string processor, int ramSize, int hardDiskSize, int graphicCard, int monitorSize, int powerSupplyVolt) : base( processor, ramSize, hardDiskSize,  graphicCard)
        {
            Processor = processor;
            RamSize = ramSize;
            HardDiskSize = hardDiskSize;
            GraphicCard = graphicCard;
            MonitorSize = monitorSize;
            PowerSupplyVolt = powerSupplyVolt;
        }

    }
    public class Laptop : Computer
    {
        public int DisplaySize { get; set; }
        public int BatteryVolt { get; set; }
        double ProcessorPrice;
        public double LaptopPriceCalculation()
        {
            if (Processor == "i3")
            {
                ProcessorPrice = 2500;
            }
            else if (Processor == "i5")
            {
                ProcessorPrice = 5000;
            }
            else if (Processor == "i7")
            {
                ProcessorPrice = 6500;
            }
            double RamPrice = 200;
            double HardDiskPrice = 1500;
            double GraphicCardPrice = 2500;
            double BatteryVoltPrice = 20;
            double DisplayPrice = 250;
            double LaptopPrice = ProcessorPrice + (RamSize * RamPrice) + (HardDiskSize * HardDiskPrice) + (GraphicCard * GraphicCardPrice) + (DisplaySize * DisplayPrice) + (BatteryVolt * BatteryVoltPrice);
            return LaptopPrice;
        }
        public Laptop(string processor, int ramSize, int hardDiskSize, int graphicCard, int displaySize, int batteryVolt) : base(processor, ramSize, hardDiskSize, graphicCard)
        {
            Processor = processor;
            RamSize = ramSize;
            HardDiskSize = hardDiskSize;
            GraphicCard = graphicCard;
            DisplaySize = displaySize;
            BatteryVolt = batteryVolt;
        }

    }
    public class Q20Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("1.Desktop\n2.Laptop");
            Console.WriteLine("Choose the option");
            int choice =int.Parse(Console.ReadLine());
           
            switch (choice)
            {
                case 1: Console.WriteLine("Enter the processor");
                    string Processor=Console.ReadLine();
                    Console.WriteLine("Enter the ram size");
                    int RamSize=int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the hard disk size");
                    int HardDiskSize = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the graphic card size");
                    int GraphicCard = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the monitor size");
                    int MonitorSize = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the power supply volt");
                    int PowerSupplyVolt = int.Parse(Console.ReadLine());
                    Desktop desktop = new Desktop(Processor, RamSize, HardDiskSize, GraphicCard, MonitorSize, PowerSupplyVolt);
                    double DesktopPrice = desktop.DesktopPriceCalculation();
                    Console.WriteLine("Desktop price is " + DesktopPrice);
                    break;

               case 2:
                    Console.WriteLine("Enter the processor");
                    string Processor2 = Console.ReadLine();
                    Console.WriteLine("Enter the ram size");
                    int RamSize2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the hard disk size");
                    int HardDiskSize2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the graphic card size");
                    int GraphicCard2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the Display Size");
                    int DisplaySize = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the Battery volt");
                    int BatteryVolt = int.Parse(Console.ReadLine());
                    Laptop laptop= new Laptop(Processor2, RamSize2, HardDiskSize2, GraphicCard2,DisplaySize, BatteryVolt);
                    double LaptopPrice = laptop.LaptopPriceCalculation();
                    Console.WriteLine("Laptop price is " + LaptopPrice);
                    break;
                Default: Console.WriteLine("Invalid Input");

            }
        }
    }
}
