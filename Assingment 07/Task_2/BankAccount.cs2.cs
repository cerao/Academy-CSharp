using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public partial class BankAccount
    {
        public void Deposit(decimal Amount)
        {
            this.Balance.Amount += Amount;
        }
        public void Withdraw(decimal Amount)
        {
            if(this.Balance.Amount > Amount)
                this.Balance.Amount -= Amount;
            else
            {
                Console.WriteLine("You don't have enough money");
            }

        }
        public decimal? BalanceCheck()
        {            

                return this.Balance.Amount;
                Console.WriteLine("you dont have " + this.Balance.Amount + "Acount");
           
            
        }
    }
}
