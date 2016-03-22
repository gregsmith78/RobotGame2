using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotV2
{
    class Roller : Robot

    {
        int gears;
        bool hasCanon;
        int shotsFired;
        int ammo;

        public Roller(string Name, int Health, int Damage, int Gears, int ShotFired) {
            name = Name;
            health = Health;
            damage = Damage;
            gears = Gears;
            hasCanon = true;
            shotsFired = ShotFired;
            ammo = 30;

    }
    public int ShotsFiredFromTank() {
            ammo -= shotsFired;
            Console.WriteLine("You have " + ammo + " rounds of ammo left.");
            return ammo;
        }
    }
}
