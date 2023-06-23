using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public struct Balance
    {

        private Currency _currency { get; set; }
        public decimal _amount { get; set; }

        public Balance(Currency currency, decimal amount)
        {
            _currency = currency;
            _amount = amount;
        }
        public Currency Currency
        {
            get
            {
                return _currency;
            }
            set
            {
                _currency = value;
            }
        }

        public decimal Amount
        {
            get
            {
                return _amount;
            }
            set
            {
                _amount = value;
            }
        }


    }
}
