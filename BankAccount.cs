using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountManSys
{
    internal class BankAccount
    {
        private string AccountNumber;
        private string AccountHolderName;
        private decimal Balance;
        public static Dictionary<string, string> AccountInformation = new Dictionary<string, string>();
        public static List<decimal> Balances = new List<decimal>();
        public static List<string> AccountNumbers = new List<string>(); 
        public void AccountInfo(string accountHolderName, string accountNumber)
        {
            Balance = 0; //Setting defualt account balance 
            AccountInformation.Add(accountNumber, accountHolderName);

        }

        public void InitialDeposit(double Deposit, string accountHolderNumber, string accountNumber)
        {
            
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
            Console.WriteLine("Press enter ot continue...");
            Console.ReadKey();

        }

        public void GetAccountInfo()
        {
        
        }
    }
}
