using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SampleQuestionsAssignment
{
    public class Movie
    {
        public static string Name { get; set; }
        public int TicketId { get; set; }
        public string SeatNumber { get; set; }
        public Movie(string name, int ticketId, string seatNumber)
        {
            Name = name;
            TicketId = ticketId;
            SeatNumber = seatNumber;
        }

        public Movie()
        {
        }

        public Movie ReturnMovieDeatails(string name,int ticketId,string seatNumber)
        {
            Name = name;
            TicketId = ticketId;
            SeatNumber = seatNumber;
            Movie movie = new Movie(Name, TicketId, SeatNumber);
            return this;
        }
    }
    internal class Q2Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the movie name");
                string Name = Console.ReadLine();
                Console.WriteLine("Enter the ticket id");
                int TicketId = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the seat number");
                string SeatNumber = Console.ReadLine();
                Movie movie = new Movie();
                var result = movie.ReturnMovieDeatails(Name, TicketId, SeatNumber);
                Console.WriteLine("Movie name: " + Name);
                Console.WriteLine("Ticket id: " + result.TicketId);
                Console.WriteLine("Seat Number: " + result.SeatNumber);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
