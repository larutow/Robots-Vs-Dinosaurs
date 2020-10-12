using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Robot
    {
        //member variables
        public string name;
        public int health;
        public int powerLevel;
        public Weapon weapon;

        //constructor
        public Robot(string name, int health, int powerLevel, Weapon weapon)
        {
            this.name = name;
            this.health = health;
            this.powerLevel = powerLevel;
            this.weapon = weapon;

        }
        //member methods
        public void Attack(Dinosaur targetDinosaur)
        {
            Console.WriteLine(name + " attacks " + targetDinosaur);
            if (targetDinosaur.health < weapon.attackPower)
            {
                targetDinosaur.health = 0;
                Console.WriteLine(targetDinosaur.type + " has fallen in battle");
            }
            else
            {
                targetDinosaur.health -= weapon.attackPower;
                Console.WriteLine(targetDinosaur.type + " takes " + weapon.attackPower + " damage and has "+targetDinosaur.health+" HP remaining");
            }
        }

    }
}
