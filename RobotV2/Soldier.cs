using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotV2
{
    class Soldier : Robot
    {
        double height;
        double weight;
        int strength;

        public Soldier(string Name, int Health, double Height, double Weight, int Strength)
        {

            name = Name;
            health = Health;
            height = Height;
            weight = Weight;
            strength = Strength;
        }

    }
}



















