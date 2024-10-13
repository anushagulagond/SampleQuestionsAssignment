using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleQuestionsAssignment
{
    internal class Q3Program
    {
        public static void Main(string[] args)
        {
            int i = 1;
            do
            {
                int j = 1;
                do
                {
                    Console.WriteLine($"{i} " + j);
                    j++;
                } while (j <= 2);

                i++;
            } while (i <= 5);
        }
    }
}
