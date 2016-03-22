using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotV2
{
    class Flyer : Robot
    {

    
    public Flyer(string Name, int Health, int Damage) {
            name = Name;
            health = Health;
            damage = Damage;
           
    }
    public int isFlying(int Speed) {
            speed = Speed;
            if (speed < 150 && speed > 5) {
                Console.WriteLine("Almost ready for take off!");
            }
            else if (speed < 200) {
                Console.WriteLine("In the middle of the ascent!");
            }
            else if (speed > 275) {
                Console.WriteLine("You're cruising above clouds!");
            }
            else {
                Console.WriteLine("You're grouded!");
            }
            return speed;
    }
   
    }
}
