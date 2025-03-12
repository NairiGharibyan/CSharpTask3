using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketBookingSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {


            List<MovieTickec> seats = new List<MovieTickec>
        {
            new MovieTickec("Scarface", "A1"),
            new MovieTickec("Scarface", "A2"),
            new MovieTickec("Scarface", "A3"),
            new MovieTickec("Scarface", "B1"),
            new MovieTickec("Scarface", "B2")
        };

            foreach (MovieTickec tmp in seats) { 
                tmp.display_seats();
            }
            Console.WriteLine();
            Console.WriteLine("Choose your seat");
            string opt = Console.ReadLine();
            foreach (MovieTickec tmp in seats) {
                if(tmp.SeatNumber  == opt)
                {

                    tmp.BookTicket(opt);
                    break;
                }
            }
            Console.ReadLine();
            


        }
    }
}
