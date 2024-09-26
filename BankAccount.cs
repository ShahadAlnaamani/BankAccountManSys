using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountManSys
{
    public class BankAccount
    {
        private string AccountNumber;
        private string AccountHolderName;
        private decimal Balance;
       // public static Dictionary<string, string> AccountInformation = new Dictionary<string, string>(); //Account number || Account Holder Name
        //public static List<decimal> Balances = new List<decimal>();
      //  public static List<string> AccountNumbers = new List<string>();

        public static Dictionary<string, (string, decimal)> AllAccounts = new Dictionary<string, (string, decimal)>(); //Account number || Account Holder Name || Balance


        public void AddNewUser(string AccountHolderName, string AccountNumber) //If user does not want to add initial deposit 
        {
            decimal InitialInput = 0;
            AllAccounts.Add(AccountNumber, (AccountHolderName, InitialInput));
        }

        public void AddNewUser(string AccountHolderName, string AccountNumber, decimal InitialInput)  //If initial input is gived 
        {
            
           // AccountInformation.Add(accountNumber, accountHolderName);


            AllAccounts.Add(AccountNumber, (AccountHolderName, InitialInput));

        }
        
        public void InitialDeposit(double Deposit, string AccountHolderName, string AccountNumber)
        {
            //if initial balance chosen then this is called first then goes to account info 
            //get initial input then send it toaccount info with all info 
            Console.Write("\nEnter intitial deposit: ");
            decimal InitialInput = 0;
            try
            {
                InitialInput = decimal.Parse(Console.ReadLine());
            }catch (Exception ex) { Console.WriteLine("<!>"+ex.Message+"<!>"); }

            AddNewUser(AccountNumber, AccountHolderName, InitialInput);
        }
         

        public void Deposit()
        {
            Console.Clear();
            Console.WriteLine("\n$   C I T Y   B A N K   $\n\n");
            Console.WriteLine("NEW DIPOSIT");

            Console.Write("\nEnter Account Number: ");
            string Account = Console.ReadLine();
            
            if (AccountInformation.ContainsKey(Account))
            {
                int x = AccountNumbers.IndexOf(Account);
                decimal CurrentBalance = Balances[x];

                Console.WriteLine($"Your current balance is ${CurrentBalance}");
                Console.WriteLine("\nEnter Amount: ");
                decimal Add = 0;
                try
                {
                    Add = decimal.Parse(Console.ReadLine());
                }catch (Exception ex) { Console.WriteLine("<!>"+ex.Message+"<!>"); }

                if (Add > 0)
                {
                    Balances[x] = Balances[x] + Add;

                    Console.WriteLine("New Balance: " + Balances[x]);
                }
                else { Console.WriteLine("<!>The value is invalid<!>"); }
            }

            else { Console.WriteLine("<!>This account does not exist<!>"); }
            Console.WriteLine("Press enter ot continue...");
            Console.ReadKey();
        }

        public void Withdraw()
        {
            Console.Clear();
            Console.WriteLine("\n$   C I T Y   B A N K   $\n\n");
            Console.WriteLine("WITHDRAW");
            Console.Write("\nEnter Account Number: ");
            string Account = Console.ReadLine();

            if (AccountInformation.ContainsKey(Account))
            {
                int x = AccountNumbers.IndexOf(Account);
                decimal CurrentBalance = Balances[x];

                Console.WriteLine($"Your current balance is ${CurrentBalance}");
                Console.WriteLine("\nEnter Amount: ");
                decimal Minus = 0;
                try
                {
                    Minus = decimal.Parse(Console.ReadLine());
                }
                catch (Exception ex) { Console.WriteLine("<!>" + ex.Message + "<!>"); }

                if (Minus < CurrentBalance)
                {
                    Balances[x] = Balances[x] - Minus;

                    Console.WriteLine("New Balance: " + Balances[x]);
                }
                else { Console.WriteLine("<!>The value is invalid<!>"); }
            }
            else { Console.WriteLine("<!>This account does not exist<!>"); }
            Console.WriteLine("Press enter ot continue...");
            Console.ReadKey();
        }

        public void GetAccountInfo()
        {
            Console.Clear();
            Console.WriteLine("\n$   C I T Y   B A N K   $\n\n");
            Console.WriteLine("VIEW ACCOUNT");
            Console.Write("\nEnter Account Number: ");
            string Account = Console.ReadLine();

            if (AccountInformation.ContainsKey(Account))
            {
                int x = AccountNumbers.IndexOf(Account);
                decimal CurrentBalance = Balances[x];
                string Name = AccountInfo[Account].Value;
                Console.WriteLine($"Account Number: {Account} Name:{}");
                Console.WriteLine($"Your current balance is ${CurrentBalance}");
            
            }
            else { Console.WriteLine("<!>This account does not exist<!>"); }
            Console.WriteLine("Press enter ot continue...");
            Console.ReadKey();
        }
    }
}
