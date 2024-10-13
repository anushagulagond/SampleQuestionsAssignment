using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleQuestionsAssignment
{
    public class Q12Program
    {
        public int[] FindStudentsRank(int[ , ] stdmarks)
        {
            int num = stdmarks.GetLength(0);
            int[] total=new int[num];
            int[] Rank = new int[num];
            for (int i = 0; i <num; i++)
            { 
                for(int j=0; j < 5; j++)
                {
                    total[i] = total[i] + stdmarks[i,j];
                }
            }
            for(int i = 0; i < Rank.Length; i++)
            {
                Rank[i] = i+1;
            }
            for(int i = 0; i < Rank.Length; i++)
            {
                for(int j=i+1;j < total.Length; j++)
                {
                    if (total[i] < total[j])
                    {
                        int temp = Rank[i];
                        Rank[i] = Rank[j];
                        Rank[j] = temp;
                    }
                }
            }
            return Rank;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of students");
            int num=int.Parse(Console.ReadLine());
            int[ , ] stdMarks = new int[num,5];
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine($"Enter marks for Student {i+1}");
                for (int j = 0; j < 5; j++)
                {
                    stdMarks[i,j] = int.Parse(Console.ReadLine());
                }
            }
            Q12Program q12Program = new Q12Program();
            int[] RankResult = q12Program.FindStudentsRank(stdMarks);
            for (int i = 0; i < RankResult.Length; i++)
            {
                Console.WriteLine($"Rank of student {i+1} is " + RankResult[i]);
            }

        }
    }
}
