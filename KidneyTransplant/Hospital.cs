using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KidneyTransplant
{
    internal class Hospital
    {
        public string TestResult;
        
        public string outcome;
        
        public Hospital() 
        {

        }

        public void GoToHospital() 
        {
            var bernt = new Bernt("Bernt", 46);
            
            Console.WriteLine("Welcome to the ER");
            Console.WriteLine($"Patient: Name: {bernt.Name} Age: {bernt.Age} ");
            Console.WriteLine("Send for testing? Y/N");
            var userChoice = Console.ReadLine();
                userChoice = userChoice.ToUpper();

            if (userChoice == "Y") 
            {
                Console.WriteLine("Your testresults: No kidney fuction");
            }
            else { Console.WriteLine("you ar heading for the morgue"); }

            Random random = new Random();
           int chance = random.Next(1, 6);

            if (chance <= 4) 
                {
                    var kåre = new Kaare("Kåre", 52);
                    Console.WriteLine("Your kidneys are damaged...");
                    Console.WriteLine($"But we found a live donor match: Name: {kåre.Name} Age: {kåre.Age}");
                    Console.WriteLine("We got premision to disclose his ID to you");
                    Console.WriteLine($"it's your cusin {kåre.Name}, and he is on his way right now");
                    Console.WriteLine("Will you take the transplant? Y/N");
                   var userChoice1 = Console.ReadLine();
                    userChoice1 = userChoice1.ToUpper();
                    if (userChoice1 == "Y") 
                    {
                        Console.WriteLine("Going to the operatingroom");
                    Thread.Sleep(1500);
                    Operation();
                        Console.WriteLine($"The operation was {outcome}");
                    Thread.Sleep(1000);
                    var home = new Home();
                    home.GoHome();
                }

                    else { Console.WriteLine("Bernt Died this night"); }
            
                }

                else { Console.WriteLine("There is nothing we could do, do you need to call someone?");
                        Thread.Sleep(1000);
                        Console.WriteLine("Bernt Died this night");
                     }


        }

        public void Operation() 
        {
            Random random = new Random();
            int chance = random.Next(1, 3);
            if (chance == 1) 
            { outcome = "a success, prognosis: full recovery";
              
            }

            else if (chance == 2) 
            {
                outcome = "success, but the recovery will be long and hard, prognosis: partial recovery";
            }
            else { outcome = "FAILIURE, dialyses and just a couple of weeks to live"; }
        }
    }
}
