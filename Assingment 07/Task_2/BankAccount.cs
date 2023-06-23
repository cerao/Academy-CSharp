using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public partial class BankAccount
    {
        public int _AccountNumber { get; set; }
        public string _AccountHolderName { get; set; }
        public Balance Balance = new Balance();

        public BankAccount(int AccountNumber, string AccountHolderName,Balance b)
        {
            _AccountNumber = AccountNumber;
            _AccountHolderName = AccountHolderName;
            Balance = b;
        }



    }
}
