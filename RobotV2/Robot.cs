using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotV2
{
    class Robot
    {
        public string name;
        public int health;
        public int damage;
        public int speed;
        public int strength;

        public Robot()
        {

        }
        public int PowerUp()
        {
            health += 100;
            return health;
        }
        public void SuperStrike()
        {
            strength += 75;

        }
        public void DamageFromSuperStrike()
        {
            damage -= 100;
            health -= 150;
        }
    }
    }
