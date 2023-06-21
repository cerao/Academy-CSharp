using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    internal class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string ID { get; set; }
        public Home Home { get; set; }

        public Person(string name, int age, string iD, Home home)
        {
            this.Name = name;
            this.Age = age;
            this.ID = iD;
            Home = home;
        }
    }
}
