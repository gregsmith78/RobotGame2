using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotV2
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu game = new Menu();
            game.SelectCharacter();
            Flyer cyrex = new Flyer("Cyerex", 300, 10);
            Roller cybot = new Roller("Cybot", 200, 300, 4, 13);
            cybot.ShotsFiredFromTank();
            cyrex.isFlying(383);
            Soldier cyborg = new Soldier("Cyborg", 300, 30, 450, 500);
            cyborg.SuperStrike();
            cybot.DamageFromSuperStrike();
            Console.WriteLine(cyrex.PowerUp());
            Console.ReadLine();
        }
    }
}
