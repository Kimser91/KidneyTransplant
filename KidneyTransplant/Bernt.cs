using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace KidneyTransplant
{
    internal class Bernt
    {
        public string Name;
        public string Insurance;
        public int Age;
        public string Address;
        public Bernt(string name, int age, string address, string insurance)
        {
            Name = name;
            Age = age;
            Address = address;
            Insurance = insurance;
        }

        public Bernt(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public Bernt(string name) 
        {
            Name = name;
        }
    }
}
