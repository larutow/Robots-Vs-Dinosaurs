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

        public Robot AttackTarget(Fleet fleet)
        {
            Robot targetedRobot = fleet.fleet[0];
            // make dinosaurs psychically target the robot in the fleet with the least amount of health that is greater than 0
            int leastHealth = 1;
            
            foreach (Robot robot in fleet.fleet)
            {
                if (robot.health > 0 && robot.health <= leastHealth)
                {
                    targetedRobot= robot;
                } else if(robot.health > 0 && robot.health > leastHealth)
                {
                    leastHealth = robot.health;
                    targetedRobot = robot;
                }
            }
            
            return targetedRobot;
        }

        //Deprecated attack function
        //public void Attack(Robot targetRobot)
        //{
        //    Console.WriteLine(type + " attacks " + targetRobot.name);
        //    if (targetRobot.health <= attackPower)
        //    {
        //        targetRobot.health = 0;
        //        Console.WriteLine(targetRobot.name + " has fallen in battle");
        //    }
        //    else
        //    {
        //        targetRobot.health -= attackPower;
        //        Console.WriteLine(targetRobot.name + " takes " + attackPower + " damage and has " + targetRobot.health + " HP remaining");
        //    }

        //}

        public void TryAttack(Robot targetRobot)
        {
            if(health > 0 && energy > 0)
            {
                Console.WriteLine(type + " attacks " + targetRobot.name);
                if (energy >= 10)
                {
                    energy -= 10;
                } else if (energy < 10)
                {
                    energy = 0;
                    Console.WriteLine("The " + type + " is out of energy and can no longer attack");
                }
                if (targetRobot.health <= attackPower)
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
}
