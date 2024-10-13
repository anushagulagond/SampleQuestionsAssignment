using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleQuestionsAssignment
{
    public class Q7Program
    {
        public StringBuilder WordInserting(StringBuilder word1,char ch,string word2)
        {
            int position = word1.ToString().IndexOf(ch);
            if (position >= 0)
            {
                word1.Insert(position, word2);
            }
            else
            {
                return word1;
            }
                return word1;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the word 1");
            StringBuilder Word1=new StringBuilder(Console.ReadLine());
            Console.WriteLine("Enter the character to search");
            char Ch=Char.Parse(Console.ReadLine());
            Console.WriteLine("Enter the word 2");
            string Word2 = Console.ReadLine();
            Q7Program obj = new Q7Program();
            StringBuilder Result=obj.WordInserting(Word1, Ch, Word2);
            Console.WriteLine(Result.ToString());
        }
    }
}
