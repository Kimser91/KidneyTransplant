using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KidneyTransplant
{
    internal class Kaare
    {
        public string Name;
        public string Insurance;
        public int Age;
        public string Address;
        public Kaare(string name, int age, string address, string insurance )
        {
            Name = name;
            Age = age;
            Address = address;
            Insurance = insurance;
            
           
        }

        public Kaare(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public Kaare(string name)
        {
            Name = name;
        }
    }
}
