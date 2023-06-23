using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_2;

Balance balance = new Balance(Currency.GEL,0);

BankAccount  bankAccount = new BankAccount(123456789,"saxeli",balance);



bankAccount.Deposit((decimal)46.3);
bankAccount.Withdraw((decimal)50);

bankAccount.Deposit((decimal)456.3);
bankAccount.Deposit((decimal)4600.3);


bankAccount.Withdraw((decimal)30);

Console.WriteLine(bankAccount.BalanceCheck());

