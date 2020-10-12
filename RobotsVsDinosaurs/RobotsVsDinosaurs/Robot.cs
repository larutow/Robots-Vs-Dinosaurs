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
        

        public Dinosaur AttackTarget(Herd herd)
        {
            Dinosaur targetedDinosaur = herd.herd[0];
            // make dinosaurs psychically target the robot in the fleet with the least amount of health that is greater than 0
            int leastHealth = 1;

            foreach (Dinosaur dinosaur in herd.herd)
            {
                if (dinosaur.health > 0 && dinosaur.health <= leastHealth)
                {
                    leastHealth = dinosaur.health;
                    targetedDinosaur = dinosaur;
                }
                else if (dinosaur.health > 0 && dinosaur.health > leastHealth)
                {
                    leastHealth = dinosaur.health;
                    targetedDinosaur = dinosaur;
                }
            }

            return targetedDinosaur;
        }
        public void Attack(Dinosaur targetDinosaur)
        {
            Console.WriteLine(name + " attacks " + targetDinosaur.type);
            if (targetDinosaur.health <= weapon.attackPower)
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

        public void TryAttack(Dinosaur targetDinosaur)
        {
            if (health > 0 && powerLevel > 0)
            {
                Console.WriteLine(name + " attacks " + targetDinosaur.type +" with a " + weapon.weaponType);
                if (powerLevel >= 10)
                {
                    powerLevel -= 10;
                }
                else if (powerLevel < 10)
                {
                    powerLevel = 0;
                    Console.WriteLine(name + " is out of power and can no longer attack");
                }
                if (targetDinosaur.health <= weapon.attackPower)
                {
                    targetDinosaur.health = 0;
                    Console.WriteLine(targetDinosaur.type + " has fallen in battle");
                }
                else
                {
                    targetDinosaur.health -= weapon.attackPower;
                    Console.WriteLine(targetDinosaur.type + " takes " + weapon.attackPower + " damage and has " + targetDinosaur.health + " HP remaining");
                }
            }
        }

    }
}
