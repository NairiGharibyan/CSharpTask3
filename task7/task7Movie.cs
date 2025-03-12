using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketBookingSystem
{
    public class MovieTickec
    {
        public string MovieName;
        public string SeatNumber;
        bool isBooked;

        public MovieTickec(string name, string number) {
            MovieName = name;
            SeatNumber = number;
            isBooked = false;
        }
        public void display_seats() {
            if (isBooked)
            {
                Console.WriteLine($"{SeatNumber} (Booked)");
            }
            else {
                Console.WriteLine($"{SeatNumber} (Available)");
            }
        }
        public void BookTicket(string option)
        {
            if (option == SeatNumber)
            {
                if (isBooked == true)
                {
                    Console.WriteLine($"Sorry {option} has booked already");
                }
                else
                {
                    isBooked = true;
                    Console.WriteLine($"Well Done! {option} booked");
                }
            }
        }
    }
}

