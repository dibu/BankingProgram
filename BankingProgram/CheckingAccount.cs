using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingProgram {
    internal class CheckingAccount : IAccount, IOperation {
        public Bank Bank { get; set; }
        public string AccountNo { get; set; }
        public decimal Balance { get; set; }
        public string AccountType { get ; set; }
        public string CustomerName { get; set; }


        public CheckingAccount(Bank bank, string AccountNo, decimal Balance, string AccountType, string CustomerName) {
            this.Bank = bank;
            this.AccountNo = AccountNo;
            this.Balance = Balance;
            this.AccountType = AccountType;
            this.CustomerName = CustomerName;
        }

        bool IOperation.Deposit(decimal amount) {
            IAccount account = Bank.GetAccount(this.AccountNo);
            if (account != null) {
                account.Balance += amount;
            }
            return true;
        }

        bool IOperation.Transfer(string toAccountNo, decimal amount) {
            IAccount frmaccount = Bank.GetAccount(this.AccountNo);
            IAccount toaccount = Bank.GetAccount(toAccountNo);
            if (frmaccount != null && toaccount != null) {
                if (amount > frmaccount.Balance) throw new Exception("Insufficient fund");

                frmaccount.WithDrawl(amount);
                toaccount.Deposit(amount);
            }
            return true;
        }

        bool IOperation.WithDrawl(decimal amount) {
            IAccount account = Bank.GetAccount(this.AccountNo);
            if (account != null) {
                account.Balance -= amount;
            }
            return true;
        }
    }
}
