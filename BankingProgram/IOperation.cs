using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingProgram {
    public interface IOperation {
        bool Deposit(decimal amount);
        bool WithDrawl(decimal amount);
        bool Transfer(string toAccountNo, decimal amount);
    }
}
