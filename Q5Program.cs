using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleQuestionsAssignment
{
    public class Q5Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the word");
            string Word=Console.ReadLine();
            char[] CharArray= Word.ToLower().ToCharArray();
            string result = "";
            for(int i=0;i<Word.Length;i++)
            { 
               
                if (i % 2 == 0)
                {
                    result = result + char.ToUpper(CharArray[i]);
                }
                else
                {
                    result = result + CharArray[i];
                }
            }
            Console.WriteLine(result);
        }
    }
}
