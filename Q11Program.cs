using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace SampleQuestionsAssignment
{
    public class Q11Program
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        //public Q11Program(int id, string name, double price)
        //{
        //    Id = id;
        //    Name = name;
        //    Price = price;
        //}

        public string UpdatePrice(string[] details,int id,double amount)
        {
            for (int i = 0; i < details.Length; i++)
            {
                string[] items = details[i].Split(":");
                if (int.Parse(items[0]) == id)
                {
                    return $"{items[1]} {amount}"; 
                }
            }
            return "";
            
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter number of products");
            int num=int.Parse(Console.ReadLine());
            string[] details= new string[num];
            Console.WriteLine("Enter product details");
            for (int i = 0; i < num; i++)
            {
                details[i] = Console.ReadLine();
            }
            Console.WriteLine("Enter the product id");
            int Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the amount to update");
            double amount=double.Parse(Console.ReadLine());
            Q11Program q11Program = new Q11Program();
            var result=q11Program.UpdatePrice(details, Id, amount);
            if (result == "")
            {
                Console.WriteLine("Invalid id");
            }
            else
            {
                Console.WriteLine(result);
            }
        }
    }
}
