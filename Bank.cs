using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BankAccountManSys
{
    internal class Bank
    {
        public List<string> BankAccounts = new List<string>();
        
        public Dictionary<string, string> Information = new Dictionary<string, string>();


        public void AddAccount()
        {
            Console.Clear();
            Console.WriteLine("\n$   C I T Y   B A N K   $\n\n");
            Console.WriteLine("ADD NEW ACCOUNT");
            Console.Write("\nBank Account Number: ");
            string AccountNumber = Console.ReadLine();

            if (!BankAccounts.Contains(AccountNumber))
            {
                BankAccounts.Add(AccountNumber);
                Console.Write("\nAccount Holders Name: ");
                string  AccountHolder = Console.ReadLine();

                Information.Add(AccountNumber, AccountHolder);

                Console.WriteLine("\n1. To Add Balance Now \n2.To Add Balance Later");
                Console.Write("\nEnter: ");
                int Choice = 0;
                try
                {
                    Choice = int.Parse(Console.ReadLine());
                }catch(Exception ex) { Console.WriteLine("<!>" + ex.Message + "<!>"); }

                if (Choice == 1)
                {
                    Console.Write("\nBalance: ");
                    try
                    {
                        decimal Balance = decimal.Parse(Console.ReadLine());
                        //Send to add deposit
                    }
                    catch (Exception ex) { Console.WriteLine("<!>" + ex.Message + "<!>"); }
                }

                else if (Choice == 2) 
                { }

                else { Console.WriteLine("<!>Improper input<!>"); }
            }

            else 
            { Console.WriteLine("<!>This bank account already exists<!>"); }

            Console.WriteLine("Press enter to continue...");
            Console.ReadKey();
        }

        public void GetAccountByNumber() 
        {
            Console.Clear();
            Console.WriteLine("\n$   C I T Y   B A N K   $\n\n");
            Console.WriteLine("SEARCH FOR ACCOUNT");
            Console.WriteLine("Enter Account Number: ");
            string AccountNumber = Console.ReadLine();

            if (Information.ContainsKey(AccountNumber))
            {
                //Get account info -> display account 
            }
        }

        public void DisplayAllAccounts() 
        {
            Console.Clear();
            Console.WriteLine("\n$   C I T Y   B A N K   $\n\n");
            Console.WriteLine("ALL ACCOUNTS");

            foreach(KeyValuePair<string,string> p in Information) 
            {
                Console.WriteLine($"Account Number: {p.Key} \nAccount Holder Name: {p.Value}");
                Console.WriteLine();
            }
        }
    }
}
