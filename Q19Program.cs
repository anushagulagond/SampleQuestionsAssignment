using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleQuestionsAssignment
{
    public class Book
    {
        private string Title { get; set; }
        private string Author { get; set; }
        private int NumPages { get; set; }
        private DateTime DueDate { get; set; }
        private DateTime ReturnedDate { get; set; }

        public Book()
        {
        }

        public Book(string title, string author, int numPages, DateTime dueDate, DateTime returnedDate)
        {
            Title = title;
            Author = author;
            NumPages = numPages;
            DueDate = dueDate;
            ReturnedDate = returnedDate;
        }

        public double AveragePagesreadPerDay(int daysToRead)
        {
            return NumPages / daysToRead;
        }
        public double CalculateLateFee(double dailyLateFeeRate)
        {
            double NumberOfDaysLate = (ReturnedDate - DueDate).TotalDays;
            return NumberOfDaysLate * dailyLateFeeRate;

        }
    }
    public class Q19Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the title");
            string Title=Console.ReadLine();
            Console.WriteLine("Enter the Author");
            string Author=Console.ReadLine();
            Console.WriteLine("Enter the number of pages");
            int NumOfPages=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the due date");
            DateTime DueDate=DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter the return date");
            DateTime ReturnedDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter the days to read");
            int DaysToRead=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the daily late feeRate");
            double LateFee=double.Parse(Console.ReadLine());

            Book book = new Book(Title,Author,NumOfPages,DueDate,ReturnedDate);
            double AvgResult=book.AveragePagesreadPerDay(DaysToRead);
            Console.WriteLine("Average Pages to Read Per Day: " + AvgResult);
            double LateFeeResult = book.CalculateLateFee(LateFee);
            Console.WriteLine("Late Fee: " + LateFeeResult);
        }
    }
}
