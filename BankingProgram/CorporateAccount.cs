using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingProgram {
    public class CorporateAccount : InvestmentAccount {
        public CorporateAccount(Bank bank, string AccountNo, decimal Balance, string AccountType, string CustomerName) : base(bank, AccountNo, Balance, AccountType, CustomerName) {
        }
    }
}
