using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleQuestionsAssignment
{
    public class InvalidFlavourException : Exception
    {
        public string Message;

        public InvalidFlavourException(string message)
        {
            Message = message;
        }
    }
    public class Cake
    {
        public string Flavour { get; set; }
        public int QuantityInKg { get; set; }
        public double PricePerKg { get; set; }

        public Cake(string flavour, int quantityInKg, double pricePerKg)
        {
            Flavour = flavour;
            QuantityInKg = quantityInKg;
            PricePerKg = pricePerKg;
        }

        public bool CakeOrder()
        {
            if(Flavour=="Chocolate"|| Flavour=="Red Velvet"|| Flavour == "Vanilla")
            {
                if (QuantityInKg > 0)
                {
                    return true;
                }
                else
                {
                    throw new Exception("Quantity must be greater than zero");
                }
            }
            else
            {
                throw new InvalidFlavourException("Flavour not available. Please select the available flavour");
            }
            
        }
        public double CalculationPrice()
        {
            double Discount = 0 ;
            if (Flavour == "Vanilla")
            {
                Discount = 3;
            }
            else if (Flavour == "Chocolate")
            {
                Discount = 5;
            }
            else if (Flavour == "Red Velvet")
            {
                Discount = 10;
            }
            double TotalPrice = QuantityInKg * PricePerKg;
            double DiscountPrice = TotalPrice - (TotalPrice * Discount / 100d);
            return DiscountPrice;
        }
    }
    public class Q25Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the flavour");
            string Flavour=Console.ReadLine();
            Console.WriteLine("Enter the quantity in kg");
            int QuantityInKg=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the price per kg");
            double PricePerKg=double.Parse(Console.ReadLine());
            Cake cake = new Cake(Flavour,QuantityInKg,PricePerKg);
            try
            {
                if (cake.CakeOrder())
                {
                    double TotalPrice = cake.CalculationPrice();
                    Console.WriteLine("Price after discount is " + TotalPrice);
                }
            }
            catch (InvalidFlavourException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
