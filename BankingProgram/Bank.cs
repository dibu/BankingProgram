using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingProgram {
    public class Bank {
        public string Name { get; private set; }
        public List<IAccount> BankAccounts  = new List<IAccount>();
        public Bank(string BankName) {
            this.Name = BankName;
            
        }
        public void CreateAccount(IAccount account) {
            BankAccounts.Add(account);
        }

        public IAccount GetAccount(string accountNo) { 
            return BankAccounts?.Where(x=> x.AccountNo == accountNo).FirstOrDefault()?? throw new Exception("Invalid Account");
        }
    }
}
