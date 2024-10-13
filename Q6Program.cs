using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleQuestionsAssignment
{
    internal class Q6Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string input = Console.ReadLine();
            if (input.Length > 0)
            {
                string[] Array = input.ToUpper().Split(":");
                for (int i = 0; i < Array.Length; i++)
                {
                    int count = 1;
                    if (Array[i] != "\0")
                    {
                        for (int j = i + 1; j < Array.Length; j++)
                        {
                            if (Array[i].Equals(Array[j]))
                            {
                                count++;
                                Array[j] = "\0";
                            }
                        }
                        Console.WriteLine($"{Array[i]}: {count}");
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid length");
            }
        }
    }
}
