using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingProgram {
    public interface IAccount : IOperation{
        string AccountNo { get; set; }
        decimal Balance { get; set; }
        string AccountType { get; set; }
        string CustomerName { get; set; }
    }
}
