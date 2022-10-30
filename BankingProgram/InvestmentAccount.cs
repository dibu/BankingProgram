using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingProgram {
    public abstract class InvestmentAccount : IAccount {
        public Bank Bank { get; private set; }
        public string AccountNo { get; set; }

        public decimal Balance { get; set; }

        public string AccountType { get; set; }

        public string CustomerName { get; set; }

        public InvestmentAccount(Bank bank, string AccountNo, decimal Balance, string AccountType, string CustomerName) {
            this.AccountNo = AccountNo;
            this.Balance = Balance;
            this.AccountType = AccountType;
            this.CustomerName = CustomerName;
            this.Bank = bank;
        }
        public bool Deposit(decimal amount) {
            IAccount account = Bank.GetAccount(this.AccountNo);
            if (account!=null) {
                account.Balance += amount;
            }
            return true;
        }

        public bool Transfer(string toAccountNo, decimal amount) {
            IAccount frmaccount = Bank.GetAccount(this.AccountNo);
            IAccount toaccount = Bank.GetAccount(toAccountNo);
            if (frmaccount != null && toaccount != null) {
                if (amount > frmaccount.Balance) throw new Exception("Insufficient fund");

                frmaccount.WithDrawl(amount);
                toaccount.Deposit(amount); 
            }
            return true;
        }

        public bool WithDrawl(decimal amount) {
            IAccount account = Bank.GetAccount(this.AccountNo);
            if (account != null) {

                if(account.GetType().Name== "IndividualAccount" && amount>=500) throw new Exception("Withdrwal limit exceeded");

                account.Balance -= amount;
            }
            return true;
        }
    }
}
