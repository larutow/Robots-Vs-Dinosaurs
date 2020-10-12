using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace RobotsVsDinosaurs
{
    class Fleet
    {
        //member variables
        public List<Weapon> arsenal;
        public List<Robot> fleet;
        public bool alive;
        public Random rng = new Random();

        //ctor
        public Fleet()
        {
            arsenal = new List<Weapon>();
            fleet = new List<Robot>();
            alive = true;
            Weapon weapon1 = new Weapon("sword", 15, 1);
            Weapon weapon2 = new Weapon("blaster", 15, 2);
            Weapon weapon3 = new Weapon("knife", 5, 3);
            Weapon weapon4 = new Weapon("bass cannon", 18, 4);
            Weapon weapon5 = new Weapon("boomerang", 6, 5);
            Weapon weapon6 = new Weapon("AWP", 25, 6);
            AddToArsenal(weapon1);
            AddToArsenal(weapon2);
            AddToArsenal(weapon3);
            AddToArsenal(weapon4);
            AddToArsenal(weapon5);
            AddToArsenal(weapon6);

            Robot robot1 = new Robot("Megatron", 50, 100, ChooseWeapon());
            Robot robot2 = new Robot("Starscream", 40, 100, ChooseWeapon());
            Robot robot3 = new Robot("Cyclonus",30, 100, ChooseWeapon());

            AddToFleet(robot1);
            AddToFleet(robot2);
            AddToFleet(robot3);

        }

        //member methods
        public void AddToFleet(Robot robot)
        {
            fleet.Add(robot);
        }

        public void AddToArsenal(Weapon weapon)
        {
            arsenal.Add(weapon);
        }

        public Weapon ChooseWeapon()
        {
            Weapon chosenWeapon = arsenal[0];
            
            int weaponID = rng.Next(1, 7);
            foreach (Weapon weapon in arsenal)
            {
                if(weaponID == weapon.uniqueId)
                {
                    chosenWeapon = weapon;
                }
            }
            return chosenWeapon;
        }

        public void AliveStatus()
        {
            foreach (Robot robo in fleet)
            {
                alive = false;
                if (robo.health == 0)
                {
                    alive = false;
                }
                else if (robo.health > 0)
                {
                    alive = true;
                    break;
                }
            }   
        }

    }
}
