using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleQuestionsAssignment
{
    public class Q26Program
    {
        public static ArrayList Attendance = new ArrayList();
        public bool RemoveStudent(string name)
        {
            foreach (var item in Attendance)
            {
                if (item.Equals(name))
                {
                    return true;
                }
            }
            return false;
        }
        public void SortTheAttendance()
        {
            Attendance.Sort();
        }
        public static void Main(string[] args)
        {
            Attendance.Add("John");
            Attendance.Add("Peter");
            Attendance.Add("Jacob");
            Attendance.Add("Archie");
            Attendance.Add("Sophie");
            Attendance.Add("Veronica");
            Attendance.Add("Elizabeth");
            Attendance.Add("Charles");
            Console.WriteLine("1.Remove student\n2.Sort attendance\nEnter your choice");
            int choice=int.Parse(Console.ReadLine());
            Q26Program q26Program = new Q26Program();
            switch (choice)
            {
                case 1: Console.WriteLine("Enter the student name");
                    string Name=Console.ReadLine();
                    if (q26Program.RemoveStudent(Name))
                    {
                        Console.WriteLine("Removed successfully");
                    }
                    break;
                case 2: 
                    q26Program.SortTheAttendance();
                    foreach(var item in Attendance)
                    {
                        Console.WriteLine(item);
                    }
                    break;
                Default: Console.WriteLine("Invalid input");
                    break;
            }
        }
    }
}
