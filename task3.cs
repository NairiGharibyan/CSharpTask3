using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{

    public class BankAccount {
            int AccNumber { get;  set; }
            string HolderName { get; set; }

            public int Balance { get; set; }

        public BankAccount(int arg1, string arg2, int arg3) {
            AccNumber = arg1;
            HolderName = arg2;
            Balance = arg3;
        }

        public void Deposit(int amount) {
            Balance += amount;
        }

        public void Withdraw(int amount) {
            if (Balance >= amount)
            {
                Balance -= amount;
            }
            else {
                Console.WriteLine("Error occured, insufficient funds");
            }
        }

        

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount acc1 = new BankAccount(11, "Arnold", 2000);
            acc1.Balance = 2000;
            Console.WriteLine(acc1.Balance);
            
            acc1.Deposit(3000);
            acc1.Withdraw(9000);

