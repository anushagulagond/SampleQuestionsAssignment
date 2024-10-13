using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleQuestionsAssignment
{
    internal class Q1Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter an integer value");
                int IntValue = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter an float value");
                float FloatValue = float.Parse(Console.ReadLine());
                Console.WriteLine("Enter an double value");
                double DoubleValue = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter an long value");
                long LongValue = long.Parse(Console.ReadLine());
                Console.WriteLine("Enter an string");
                string str = Console.ReadLine();
                Console.WriteLine("int: " + IntValue);
                Console.WriteLine("float: " + FloatValue);
                Console.WriteLine("double: " + DoubleValue);
                Console.WriteLine("long: " + LongValue);
                Console.WriteLine("string: " + str);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
