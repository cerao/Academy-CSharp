using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    internal class Home
    {
        public string Name { set; get; }
        public string Address { set; get; }

        public Home(string name, string address)
        {
            this.Name = name;
            this.Address = address;
        }
    }
}
