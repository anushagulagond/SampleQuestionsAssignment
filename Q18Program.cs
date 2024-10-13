using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleQuestionsAssignment
{
    public class Owner
    {
        protected string ownername { get; set; }
    }
    public class Car : Owner
    {
        internal double price { get; set; }
        private string bodyStyle { get; set; }
        public string BodyStyle { get; set; }
        public bool ValidateBodyStyle(string bodyStyle)
        {
            if(bodyStyle=="SUV"|| bodyStyle == "Sedan")
            {
                return true;
            }
            return false;
        }
        public double CalculatePrice()
        {
            if (bodyStyle == "SUV")
            {
                double result = price - (price * 10d / 100);
                return result;
            }
            else if (bodyStyle == "Sedan")
            {
                double result = price - (price * 25d / 100);
                return result;
            }
            else
            {
                return 0;
            }
        }
        public void SetOwnerName(string name)
        {
            ownername = name;

        }

        public Car(double price, string bodyStyle)
        {
            this.price = price;
            this.bodyStyle = bodyStyle;
        }
    }
    public class Q18Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the owner name: ");
            string OwnerName=Console.ReadLine();
            Console.WriteLine("Enter the car body style");
            string bodyStyle=Console.ReadLine();
            Console.WriteLine("Enter the price");
            double price=double.Parse(Console.ReadLine());
            Car car = new Car(price,bodyStyle);
            if (car.ValidateBodyStyle(bodyStyle) == true)
            {
                double result=car.CalculatePrice();
                car.SetOwnerName(OwnerName);
                Console.WriteLine($"The owner sells the {bodyStyle} type car for ${result}");
            }
            else
            {
                Console.WriteLine("Invalid Car Type");
            }
        }
    }
}
