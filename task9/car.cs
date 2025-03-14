using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentSystem
{
    internal class Car
    {
        public string Model;
        public int Year;
        bool isRented;

        public Car(string model, int year, bool isRented)
        {
            Model = model;
            Year = year;
            this.isRented = isRented;
        }

        public void RentCar() {
            if (isRented)
            {
                Console.WriteLine($"{Model} car of {Year}year has been already Rented");
            }
            else
            {
                Console.WriteLine($"You has rented {Model} car of {Year}Year");
                isRented = true;
            }
        }

        public void ReturnCar()
        {
            if (!isRented)
            {
                Console.WriteLine($"The {Model} car from {Year} is not rented, so it can't be returned.");
            }
            else
            {
                Console.WriteLine($"You have returned the {Model} car from {Year}.");
                isRented = false;
            }
        }
    }   
}

