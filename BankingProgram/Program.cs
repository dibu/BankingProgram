using System;
using BankingProgram;
public class Program {
    public static void Main() {
        Bank myBank = new Bank("MyBank");
        IAccount checkingAccount = new CheckingAccount(myBank,"CHK000001", 2000, "CheckingAccount", "Rahul");
        myBank.CreateAccount(checkingAccount);
        IAccount individualAcc = new IndividualAccount(myBank,"INDV00001", 2000, "IndividualAccount", "Dibyajyoti");
        myBank.CreateAccount(individualAcc);

        IAccount accINDV00001 = myBank.GetAccount("INDV00001");
        if (accINDV00001 != null) {
            accINDV00001.Deposit(900);
            Console.WriteLine(accINDV00001.AccountNo + " " + accINDV00001.Balance);
            accINDV00001.Deposit(400);
            Console.WriteLine(accINDV00001.AccountNo + " " + accINDV00001.Balance);
            accINDV00001.Deposit(500);
            Console.WriteLine(accINDV00001.AccountNo + " " + accINDV00001.Balance);

            accINDV00001.WithDrawl(400);
            Console.WriteLine(accINDV00001.AccountNo + " " + accINDV00001.Balance);
        }

        Console.WriteLine(checkingAccount.AccountNo + " " + checkingAccount.Balance);
        checkingAccount.Transfer(accINDV00001.AccountNo, 100400);
        Console.WriteLine(checkingAccount.AccountNo + " " + checkingAccount.Balance);
        Console.WriteLine(accINDV00001.AccountNo + " " + accINDV00001.Balance);

        accINDV00001.WithDrawl(500);
        Console.WriteLine(accINDV00001.AccountNo + " " + accINDV00001.Balance);

    }

}
