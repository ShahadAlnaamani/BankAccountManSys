using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BankAccountManSys
{
    public class Bank
    {
        List<BankAccount> bankAccounts = new List<BankAccount>();   

    
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

                Console.WriteLine("\n1. To Add Balance Now \n2. To Add Balance Later");
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
                        BankAccount bankAccount = new BankAccount();
                        bankAccount.AddNewUser(AccountNumber, AccountHolder, Balance);
                        Console.WriteLine("New Account Added Successfully :)!");
                    }
                    catch (Exception ex) { Console.WriteLine("<!>" + ex.Message + "<!>"); }
                }

                else if (Choice == 2) 
                { 
                    BankAccount bankAccount = new BankAccount();
                    bankAccount.AddNewUser(AccountNumber, AccountHolder);
                    Console.WriteLine("New Account Added Successfully :)!");
                }

                else { Console.WriteLine("<!>Improper input<!>"); }
            }

            else 
            { Console.WriteLine("<!>This bank account already exists<!>"); }
        }

        public void GetAccountByNumber() 
        {
            Console.Clear();
            Console.WriteLine("\n$   C I T Y   B A N K   $\n\n");
            Console.WriteLine("SEARCH FOR ACCOUNT");
            Console.Write("\nEnter Account Number: ");
            string AccountNumber = Console.ReadLine();

            if (Information.ContainsKey(AccountNumber))
            {
                foreach (KeyValuePair<string, (string, decimal)> account in BankAccount.AllAccounts)
                {
                    if (account.Key == AccountNumber)
                    {
                        Console.Write("\nAccount Number: {0}", account.Key, " | ");
                        Console.Write("Name: {0}", account.Value.Item1, " | ");
                        Console.Write("Balance: {0}", account.Value.Item2, "\n");
                    }
                }
            }
        }

        public void DisplayAllAccounts() 
        {
            Console.Clear();
            Console.WriteLine("\n$   C I T Y   B A N K   $\n\n");
            Console.WriteLine("ALL ACCOUNTS");

            foreach (KeyValuePair<string, (string, decimal)> account in BankAccount.AllAccounts)
            {
                Console.Write("\nAccount Number: {0} | ", account.Key);
                Console.Write("Name: {0} | ", account.Value.Item1);
                Console.Write("Balance: {0} \n", account.Value.Item2);
            }
        }
    }
}
