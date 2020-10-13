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
        public List<Robot> robots;
        public bool alive;
        public Random rng = new Random();

        //ctor
        public Fleet()
        {
            arsenal = new List<Weapon>();
            robots = new List<Robot>();
            alive = true;
            
            AddToArsenal(new Weapon("sword", 15, 1));
            AddToArsenal(new Weapon("blaster", 15, 2));
            AddToArsenal(new Weapon("knife", 5, 3));
            AddToArsenal(new Weapon("bass cannon", 18, 4));
            AddToArsenal(new Weapon("boomerang", 6, 5));
            AddToArsenal(new Weapon("AWP", 25, 6));

            Robot robot1 = new Robot("Megatron", 50, 100, arsenal);
            Robot robot2 = new Robot("Starscream", 40, 100, arsenal);
            Robot robot3 = new Robot("Cyclonus",30, 100, arsenal);
            

            AddToFleet(robot1);
            AddToFleet(robot2);
            AddToFleet(robot3);

        }

        //member methods
        public void AddToFleet(Robot robot)
        {
            robots.Add(robot);
        }

        public void AddToArsenal(Weapon weapon)
        {
            arsenal.Add(weapon);
        }

        public void RemoveRobo(Robot robot) {
            robots.Remove(robot);
        }

        public void Attack(Herd dinosaurHerd, Random rng)
        {
            int attackRoboIndex = rng.Next(0, robots.Count);
            if (robots.Count > 0)
            {
                Dinosaur roboTarget = robots[attackRoboIndex].AttackTarget(dinosaurHerd);

                //tryAttack method for dinosaurs & robots

                robots[attackRoboIndex].TryAttack(roboTarget);
                dinosaurHerd.AliveStatus();
            }
        }

        public void AliveStatus()
        {
            foreach (Robot robo in robots)
            {
                if (robo.health == 0)
                {
                    RemoveRobo(robo);
                    break;
                }
            }   
        }

    }
}
