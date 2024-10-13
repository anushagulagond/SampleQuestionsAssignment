using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleQuestionsAssignment
{
    public class Q14Program
    {
        public object CalculateDiscountPrice(object totalCost)
        {
            double TotalCost=(double)totalCost;
            double Discount;
            if (TotalCost >= 100 && TotalCost < 500)
            {
                Discount = 5 * (TotalCost / 100f);
                return TotalCost - Discount;
            }
            else if (TotalCost >= 500 && TotalCost < 1000)
            {
                Discount = 15 * (TotalCost / 100f);
                return TotalCost - Discount;
            }else if(TotalCost >= 1000)
            {
                Discount = 30 * (TotalCost / 100f);
                return TotalCost - Discount;
            }
            return TotalCost;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the total cost");
            double TotalCost = double.Parse(Console.ReadLine());
            Q14Program q14Program = new Q14Program();
            var Price= q14Program.CalculateDiscountPrice(TotalCost);
            double ResultPrice = (double)Price;
            Console.WriteLine("Price after discount is " + ResultPrice);
        }
    }
}
