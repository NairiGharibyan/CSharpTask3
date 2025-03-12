
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ConsoleAppTask2
{

    public class Contact {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Mail { get; set; }

        public Contact(string name, string phoneNumber, string mail)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Mail = mail;
        }

        public void DisplayInfo() {
            Console.WriteLine($"Name: {Name}, PhoneNumber: {PhoneNumber}, Mail: {Mail}");
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {

            Contact[] contacts = new Contact[3];
            for (int i = 0; i < contacts.Length; i++) {
                string name = Console.ReadLine();
                string phoneNumber = Console.ReadLine();
                string mail = Console.ReadLine();

                contacts[i] = new Contact(name, phoneNumber, mail);

            }

            foreach (var contact in contacts) {
                contact.DisplayInfo();
            }

                string prompt_name = Console.ReadLine();
                bool flag=false;
                for (int i = 0; i < contacts.Length; i++) {
                    if (prompt_name == contacts[i].Name) {
                        flag = true;
                        contacts[i].DisplayInfo();
                        break;
                    }
                }
                if (!flag) {
                    Console.WriteLine("Not found");
                }





         
                


            Console.ReadLine();
        }
    }
}



