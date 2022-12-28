using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skillmineproject2.Collection
{
    class GenericListBankAccount
    {

        public enum AccountType { Saving, Current }
        public class Customer
        {
            public int AccNo { get; set; }
            public string Name { get; set; }
            public AccountType AccountType;
            public List<Loan> Loans = new List<Loan>();
        }
        public class Loan
        {
            public int Id { get; set; }
            public string LoanName { get; set; }
        }
        public class Program
        {

            static void Main(string[] args)
            {
                List<Customer> list = new List<Customer>()
            {
                new Customer
                {
                    AccNo = 101,
                    Name="Manthan",
                    AccountType=AccountType.Saving,
                    Loans =
                    {
                        new Loan{Id=1,LoanName="Car"},
                        new Loan{Id=2,LoanName="Home"},
                    }
                },
                new Customer
                {
                    AccNo = 102,
                     Name="Customer2",
                    AccountType=AccountType.Current,
                    Loans =
                    {
                        new Loan{Id=1,LoanName="Business"},

                    }
                }
            };

                foreach (Customer c in list)
                {
                    Console.WriteLine($"{c.Name} ,{c.AccountType}");
                    foreach (Loan L in c.Loans)
                    {
                        Console.WriteLine("\t" + L.LoanName);
                    }
                }



            }
        }
    }
}
