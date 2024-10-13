using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleQuestionsAssignment
{
    public class Q8Program
    {
        public StringBuilder FindExponential(int number)
        {
            StringBuilder stringBuilder = new StringBuilder("Exponential is ");
            stringBuilder.Append(Math.Pow(10,number));
            return stringBuilder;
        }
        public StringBuilder ReplaceWord(string word,string word1,string word2)
        {
            StringBuilder stringBuilder = new StringBuilder(word);
            return stringBuilder.Replace(word1, word2);
        }
        public static void Main(string[] args)
        { 
            Q8Program q8Program = new Q8Program();
           
            Console.WriteLine("Choose the option\n1.Find Exponential\n2.Replace Word");
            int choice=int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter a number");
                    int num = int.Parse(Console.ReadLine());
                    string result1 = q8Program.FindExponential(num).ToString();
                    Console.WriteLine(result1);
                    break;
                case 2:
                    Console.WriteLine("Enter the sentence");
                    string sentence=Console.ReadLine();
                    Console.WriteLine("Enter the word 1 to replace");
                    string word1 = Console.ReadLine();
                    Console.WriteLine("Enter the word 2 ");
                    string word2 = Console.ReadLine();
                    string result2 = q8Program.ReplaceWord(sentence, word1, word2).ToString();
                    Console.WriteLine(result2);
                    break;
                default:
                 Console.WriteLine("Invalid Input");
                    break;
            }
            }
        }
}
