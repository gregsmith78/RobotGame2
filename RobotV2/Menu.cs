using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotV2
{
    class Menu : Robot
    {

        public Menu()
        {
        //  Flyer r1 = new Flyer("wee", 22, 333);


        }

        public void SelectCharacter()
        {
            int choice;

            Console.WriteLine("Please enter a number for which robot you would like to battle with.");
            Console.WriteLine("1 for Cyrex as a Fighter Jet Robot.");
            Console.WriteLine("2 for Cybot as a Tanker Robot.");
            Console.WriteLine("3 for Cyborg as a Soldier Robot.");

            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Cyrex!! Great selection.");
                    Console.WriteLine("Would you like to fly?");
                    break;
                case 2:
                    Console.WriteLine("Cybot!! Great selection.");
                    Console.WriteLine("Let's Roll!");
                    break;
                case 3:
                    Console.WriteLine("Cyborg!! Great selection.");
                    Console.WriteLine("It's a wrap!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number 1 through 3...");
                    break;
                   
            }
            Console.ReadLine();
        }
        
    }
}