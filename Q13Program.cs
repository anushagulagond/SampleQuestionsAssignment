using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleQuestionsAssignment
{
    public class Q13Program
    {
        public string FindWhoGotMaximumPoints(int[][] points)
        {
            int[] Total = new int[points.GetLength(0)];
            for(int i = 0; i < Total.Length; i++)
            {
                for (int j = 0; j < points[i].Length; j++)
                {
                    Total[i] += points[i][j];
                }
            }
            int Max = Total[0],student=0;
            for (int i = 0; i < Total.Length; i++)
            {
                if (Total[i] > Max)
                {
                    Max = Total[i];
                    student = i;
                }
            }
            student += 1;
            return "Student "+student+" got maximum points";
            }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of students");
            int num = int.Parse(Console.ReadLine());
            int[][] points = new int[num][];
            for(int i = 0; i < num; i++)
            {
                Console.WriteLine($"Enter the number of competitions attended by student {i+1}");
                int Competitions=int.Parse(Console.ReadLine());
                points[i]=new int[Competitions];
                Console.WriteLine($"Enter the student {i+1} points");
                for (int j = 0; j < Competitions; j++)
                {
                    points[i][j]=int.Parse(Console.ReadLine());
                }
            }
            Q13Program q13Program = new Q13Program();
           string Result= q13Program.FindWhoGotMaximumPoints(points);
            Console.WriteLine(Result);
        }
    }
}
