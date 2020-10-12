using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Dinosaur
    {
        //member variables
        public string type;
        public int health;
        public int energy;
        public int attackPower;

        //CTOR
        public Dinosaur(string type, int health, int energy, int attackPower)
        {
            this.type = type;
            this.health = health;
            this.energy = energy;
            this.attackPower = attackPower;
        }
        //member methods

        public void Attack(Robot targetRobot)
        {
            Console.WriteLine(type + " attacks " + targetRobot);
            if (targetRobot.health < attackPower)
            {
                targetRobot.health = 0;
                Console.WriteLine(targetRobot.name + " has fallen in battle");
            }
            else
            {
                targetRobot.health -= attackPower;
                Console.WriteLine(targetRobot.name + " takes " + attackPower + " damage and has " + targetRobot.health + " HP remaining");
            }

        }
    }
}
