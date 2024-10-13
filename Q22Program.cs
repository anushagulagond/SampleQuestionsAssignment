using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleQuestionsAssignment
{
    public class CarClass
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public virtual double CalculateCost(double basePrice,int currentYear)
        {
            return basePrice;
        }

        public CarClass(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
        }
    }
    public class SportsCar:CarClass
    {
        public SportsCar(string make, string model, int year) : base(make, model, year)
        {
        }

        public override double CalculateCost(double basePrice, int currentYear)
        {
            int Age = currentYear-Year;
            double totalTax = basePrice *0.10* Age;
            double TotalCost= basePrice + totalTax;
            return TotalCost;
        }

    }
    public class SUV : CarClass
    {
        public SUV(string make, string model, int year) : base(make, model, year)
        {
        }
        public override double CalculateCost(double basePrice, int currentYear)
        {
            int Age = currentYear-Year;
            double totalTax = basePrice * 0.05 * Age;
            double TotalCost = basePrice + totalTax;
            return TotalCost;
        }
    }
    public class Q22Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("1.Sports car\n2.SUV car\n3.None of the above\nChoose the option");
            int choice =int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1: Console.WriteLine("Enter the Make");
                    string Make=Console.ReadLine();
                    Console.WriteLine("Enter the model");
                    string Model=Console.ReadLine();
                    Console.WriteLine("Enter the year the car was made");
                    int Year=int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the basic price");
                    double basePrice=double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the current year");
                    int currentYear=int.Parse(Console.ReadLine());
                    SportsCar sportsCar= new SportsCar(Make, Model, Year);
                    double Cost=sportsCar.CalculateCost(basePrice, currentYear);
                    Console.WriteLine("Sports car cost is " + Cost);
                    break;
                case 2: Console.WriteLine("Enter the Make");
                    string Make2 = Console.ReadLine();
                    Console.WriteLine("Enter the model");
                    string Model2 = Console.ReadLine();
                    Console.WriteLine("Enter the year the car was made");
                    int Year2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the basic price");
                    double basePrice2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the current year");
                    int currentYear2 = int.Parse(Console.ReadLine());
                    SUV suv =new SUV(Make2, Model2, Year2);
                    double CostResult=suv.CalculateCost(basePrice2, currentYear2);
                    Console.WriteLine("SUV car cost is " + CostResult);
                    break;
                case 3:
                    Console.WriteLine("Enter the Make");
                    string Make3 = Console.ReadLine();
                    Console.WriteLine("Enter the model");
                    string Model3 = Console.ReadLine();
                    Console.WriteLine("Enter the year the car was made");
                    int Year3 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the basic price");
                    double basePrice3 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the current year");
                    int currentYear3 = int.Parse(Console.ReadLine());
                    CarClass carClass=new CarClass(Make3, Model3,Year3);
                    double ResultCost=carClass.CalculateCost(basePrice3, currentYear3);
                    Console.WriteLine("The cost is "+ResultCost);
                    break;
                Default: Console.WriteLine("Invalid input");
                    break;
            }

        }
    }
}
