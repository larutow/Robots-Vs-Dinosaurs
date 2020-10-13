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
        public Random rng = new Random();

        //constructor
        public Robot(string name, int health, int powerLevel, List<Weapon> arsenal)
        {
            this.name = name;
            this.health = health;
            this.powerLevel = powerLevel;
            weapon = ChooseWeapon(arsenal);
            

        }
        //member methods
        
        public Weapon ChooseWeapon(List<Weapon> arsenal)
        {
            Weapon chosenWeapon = new Weapon("",0,0);
            
            int weaponIndex = rng.Next(1, arsenal.Count);

            chosenWeapon.weaponType = arsenal[weaponIndex].weaponType;
            chosenWeapon.attackPower = arsenal[weaponIndex].attackPower;
            chosenWeapon.uniqueId = arsenal[weaponIndex].uniqueId;
            RemoveWeaponFromArsenal(arsenal,weaponIndex);

            return chosenWeapon;

        }

        public void RemoveWeaponFromArsenal(List<Weapon> arsenal, int weaponIndex)
        {
            arsenal.Remove(arsenal[weaponIndex]);
        }

        public Dinosaur AttackTarget(Herd herd)
        {
            Dinosaur targetedDinosaur = herd.dinosaurs[0];
            // make dinosaurs psychically target the robot in the fleet with the least amount of health that is greater than 0
            int leastHealth = 1;

            foreach (Dinosaur dinosaur in herd.dinosaurs)
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
        
        //deprecated attack function
        //public void Attack(Dinosaur targetDinosaur)
        //{
        //    Console.WriteLine(name + " attacks " + targetDinosaur.type);
        //    if (targetDinosaur.health <= weapon.attackPower)
        //    {
        //        targetDinosaur.health = 0;
        //        Console.WriteLine(targetDinosaur.type + " has fallen in battle");
        //        Console.WriteLine("");
        //    }
        //    else
        //    {
        //        targetDinosaur.health -= weapon.attackPower;
        //        Console.WriteLine(targetDinosaur.type + " takes " + weapon.attackPower + " damage and has "+targetDinosaur.health+" HP remaining");
        //        Console.WriteLine("");
        //    }
        //}

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
                    Console.WriteLine("");
                }
                if (targetDinosaur.health <= weapon.attackPower)
                {
                    targetDinosaur.health = 0;
                    Console.WriteLine(targetDinosaur.type + " has fallen in battle");
                    Console.WriteLine("");
                }
                else
                {
                    targetDinosaur.health -= weapon.attackPower;
                    Console.WriteLine(targetDinosaur.type + " takes " + weapon.attackPower + " damage and has " + targetDinosaur.health + " HP remaining");
                    Console.WriteLine("");
                }
            }
        }

    }
}
