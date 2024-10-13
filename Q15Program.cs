using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleQuestionsAssignment
{
    public class Q15Program
    {
        public void ReplaceDuplicateWithSpecialChar(ref char[] chars,char SpecialChar)
        {
            for(int i = 0;i < chars.Length; i++)
            {
               for(int j=i+1;j < chars.Length; j++)
                {
                    if (chars[i] == chars[j])
                    {
                        chars[j] = SpecialChar;
                    }
                } 
            }
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the array size");
            int size = int.Parse(Console.ReadLine());
            char[] chars = new char[size];
            Console.WriteLine("Enter the characters");
            for(int i = 0; i < size; i++)
            {
                chars[i]=char.Parse(Console.ReadLine()); 
            }
            Console.WriteLine("Enter the special character");
            char spl=char.Parse(Console.ReadLine());
            Q15Program q15Program = new Q15Program();
            q15Program.ReplaceDuplicateWithSpecialChar(ref chars,spl);
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(chars[i]);
            }
        }
    }
}
