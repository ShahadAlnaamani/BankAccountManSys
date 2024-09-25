using System;
using System.Collections.Generic;
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

        public void AccountInfo(string accountHolderNumber, string accountNumber)
        {
            Balance = 0; //Setting defualt account balance 
        }

        public void InitialDeposit(double Deposit, string accountHolderNumber, string accountNumber)
        {
            
        }


        public void Deposit()
        { 
        
        }

        public void Withdraw()
        {
        
        }

        public void GetAccountInfo()
        {
        
        }
    }
}
