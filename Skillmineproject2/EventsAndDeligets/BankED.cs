using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skillmineproject2.EventsAndDeligets
{

    public delegate void Mydeliii();
    public class BankED
    {

        public event Mydeliii Insufficient;
        public event Mydeliii Zero;
        private double accountbalence;
        public BankED(double accuntbalence)
        {

            this.accountbalence = accountbalence;

        }

        public void Credit(double ammount)            //add ammount
        {
            accountbalence += ammount;
        }
        public void Debit(double ammount)            //withdraw ammount
        {


            if (ammount > accountbalence)
            {
                Insufficient();
            }
            else
            {
                accountbalence -= ammount;
                if (accountbalence == 0)
                {
                    Zero();
                }

            }
        }

        public override string ToString()
        {
            return $"Current balence is {accountbalence}";
        }



        public static class Massage
        {
            public static void Insufficientmassage()
            {
                Console.WriteLine("Insufficient Ammount to Withdraw");
            }
            public static void Zeromassage()
            {
                Console.WriteLine("Current account balence is zero");
            }
        }


        static void Main(string[] args)
        {
            BankED b = new BankED(5000);
            b.Insufficient += new Mydeliii(Massage.Insufficientmassage);
            b.Zero += new Mydeliii(Massage.Zeromassage);



            Console.WriteLine("credit of 1000");
            b.Credit(1000);
            Console.WriteLine(b);


            Console.WriteLine("debit of 1500");
            b.Debit(1500);
            Console.WriteLine(b);


            Console.WriteLine("debit of 5000");
            b.Debit(6000);
            Console.WriteLine(b);


        }
    }




}




