namespace BankAccountManSys
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();
            BankAccount account = new BankAccount();
            bool Running = true;

            do
            {
                Console.Clear();
                Console.WriteLine("\n$   C I T Y   B A N K   $\n\n");
                Console.WriteLine("1.  Add Account");
                Console.WriteLine("2.  Deposit");
                Console.WriteLine("3.  Withdraw");
                Console.WriteLine("4.  Display All Accounts");
                Console.WriteLine("5.  View Account Details");
                Console.WriteLine("6.  End Program");
                Console.Write("\nEnter: ");
                int Choice = 0;

                try
                {
                    Choice = int.Parse(Console.ReadLine());
                }catch (Exception ex) { Console.WriteLine("<!>"+ex.Message+ "<!>"); }

                switch (Choice) 
                {
                    case 1:
                        bank.AddAccount();
                        break;

                    case 2:
                        account.Deposit();
                        break;

                    case 3:
                        account.Withdraw();
                        break;

                    case 4:
                        bank.DisplayAllAccounts();
                        break;

                    case 5:
                        bank.DisplayAllAccounts();
                        break;


                    case 6:
                        Running = false;
                        Console.WriteLine("Bye!");
                        break;

                    default:
                        Console.WriteLine("<!>Invalid Input<!>");
                        break;
                }

                Console.WriteLine("Press enter to continue...");
                Console.ReadKey();
            } while (Running != false);

        }
    }
}
