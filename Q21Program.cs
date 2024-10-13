using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleQuestionsAssignment
{
    public class Product
    {
        public decimal CalculateTotalPrice(decimal price,int quantity)
        {
           decimal TotalPrice = price * quantity;
            return TotalPrice;
        }
        public decimal CalculateTotalPrice(decimal price,int quantity,int discountPercentage)
        {
            decimal TotalPrice = (price * quantity) - (price * quantity * discountPercentage / 100);
            return TotalPrice;
        }
    }
    public class Q21Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("1.Price Without Discount\n2.Price With Discount");
            Console.WriteLine("Enter the choice");
            int choice=int.Parse(Console.ReadLine());
            Product product = new Product();
            switch (choice)
            {
                case 1: Console.WriteLine("Enter the price");
                    decimal price=decimal.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the quantity");
                    int quantity=int.Parse(Console.ReadLine()); 
                    decimal TotalPrice=product.CalculateTotalPrice(price, quantity);
                    Console.WriteLine("Total price without discount " + TotalPrice);
                    break;
                case 2: Console.WriteLine("Enter the price");
                    decimal price2 = decimal.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the quantity");
                    int quantity2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the discount percentage");
                    int DPercentage=int.Parse(Console.ReadLine());
                    decimal totalPrice=product.CalculateTotalPrice(price2, quantity2,DPercentage);
                    Console.WriteLine("Total price with dicount " + totalPrice);
                    break;
                Default: Console.WriteLine("Invalid input");
                    break;
            }
        }
    }
}
