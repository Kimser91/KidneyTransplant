using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KidneyTransplant
{
    internal class Home
    {
        public Home() { }

        public void GoHome() 
        {
            Console.WriteLine("Finaly home");
            Console.WriteLine("Do you want to go for a ride? Y/N");
               var userChoice = Console.ReadLine();
                userChoice = userChoice.ToUpper();

            if (userChoice == "Y") { new World(); }
            else { Console.WriteLine("Good Choice"); }
        }
    }
}
