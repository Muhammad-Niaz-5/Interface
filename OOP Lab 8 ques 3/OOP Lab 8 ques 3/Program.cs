using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_Lab_8_ques_3
{
    interface Itransaction
    {
        void showTransaction();
        bool getAmount();
    }
    class Transaction : Itransaction
    {
        private string tCode, date;
        private double amount, bank_amount;
        public Transaction()
        {

        }
        public Transaction(string tCode, string data, double amount)
        {
            this.tCode = tCode;
            this.date = data;
            this.amount = amount;
        }
        public void showTransaction()
        {
            Console.WriteLine("Transaction Confirmed ");
            Console.WriteLine("Transaction Amount is: " + amount + " from Account Code: " + tCode);
            Console.WriteLine("Remaining Amount is: " + bank_amount);

        }
        public bool getAmount()
        {
            if (tCode == "08464")
            {
                bank_amount = 10000;
                bank_amount -= amount;
                return true;
            }
            else
            {
                return false;

            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i == 0)
            {

                Console.WriteLine("Enter Account Code: ");
                string code = Console.ReadLine();
                Console.WriteLine("Enter amount for Transaction: ");
                double amount = double.Parse(Console.ReadLine());
                string date = "09092015";
                {
                    Transaction obj = new Transaction(code, date, amount);
                    bool val = obj.getAmount();

                    if (val == true)
                    {
                        obj.showTransaction();
                    }
                    else
                    {
                        Console.WriteLine("Invalid!!");
                    }
                }//destroying the object
                Console.ReadKey();
            }
        }
    }
}