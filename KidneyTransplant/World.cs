using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KidneyTransplant
{
    internal class World
    {
        public int CrashOdds = 1;
        public World()
        {
            GoForADrive();
        }

        public void GoForADrive() 
        {
            if (CrashOdds == 1) 
            {
                Console.WriteLine("you need to go To the hospital asap!!");
                Thread.Sleep(500);
                GoToHospital();
            }

            else { Console.WriteLine("Something is wrong in the code XD"); }


        }

        public void GoToHospital() 
        {
            Console.WriteLine("do you want to go to the hospital? Y/N");
           var userChoise = Console.ReadLine();
            userChoise = userChoise.ToUpper();

            if (userChoise == "Y") 
            {
                var hospital = new Hospital();
                hospital.GoToHospital();
            }
            else { GoForADrive(); }

        }
    }
}
