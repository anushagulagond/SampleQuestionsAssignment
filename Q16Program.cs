using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleQuestionsAssignment
{
    public class Candy
    {
        public string Flavour { get; set; }
        public int Quantity { get; set; }
        public int PricePerPiece { get; set; }
        public double TotalPrice { get; set; }
        public double Discount { get; set; }
        public bool ValidateCandyFlavour()
        {
            if (Flavour == "Strawberry" || Flavour == "Lemon" || Flavour == "Mint")
            {
                return true;
            }
            return false;
        }

        public Candy(string flavour, int quantity, int pricePerPiece)
        {
            Flavour = flavour;
            Quantity = quantity;
            PricePerPiece = pricePerPiece;
        }
    }
   public class Q16Program
    { 
        public Candy CalculateDiscountedPrice(Candy candy)
        {
            if (candy.Flavour == "Strawberry")
            {
                candy.TotalPrice = candy.Quantity * candy.PricePerPiece;
                candy.Discount = candy.TotalPrice - (candy.TotalPrice * (15d / 100));

            }
            else if(candy.Flavour == "Lemon")
            {
                candy.TotalPrice = candy.Quantity * candy.PricePerPiece;
                candy.Discount = candy.TotalPrice - (candy.TotalPrice * (10d / 100));
            }
            else if (candy.Flavour == "Mint")
            {
                candy.TotalPrice = candy.Quantity * candy.PricePerPiece;
                candy.Discount = candy.TotalPrice - (candy.TotalPrice * (5d / 100));
            }
            return candy;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the flavour");
            string Flavour=Console.ReadLine();
            Console.WriteLine("enter the quantity");
            int Quantity=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the price per piece");
            int PPP = int.Parse(Console.ReadLine());

            Candy candy = new Candy(Flavour,Quantity,PPP);
            Q16Program q16Program = new Q16Program();

            if (candy.ValidateCandyFlavour()==true)
            {
                q16Program.CalculateDiscountedPrice(candy);
                Console.WriteLine("Flavour: "+candy.Flavour);
                Console.WriteLine("Quantity: "+candy.Quantity);
                Console.WriteLine("Price per piece: "+candy.PricePerPiece);
                Console.WriteLine("Total Price: " + candy.TotalPrice);
                Console.WriteLine("Dicount Price: " + candy.Discount);
            }
            else
            {
                Console.WriteLine("Invalid flavour");
            }
        }
    }
}
