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
        public List<Robot> fleet;
        public bool alive;
        
        //ctor
        public Fleet()
        {
            fleet = new List<Robot>();
            alive = true;
            Weapon sword = new Weapon("sword", 10);
            Weapon blaster = new Weapon("blaster", 15);
            Weapon knife = new Weapon("knife", 5);
            Robot robot1 = new Robot("Megatron", 50, 100, sword);
            Robot robot2 = new Robot("Starscream", 40, 100, blaster);
            Robot robot3 = new Robot("Cyclonus",30, 100, knife);

            addToFleet(robot1);
            addToFleet(robot2);
            addToFleet(robot3);
        }

        //member methods
        public void addToFleet(Robot robot)
        {
            fleet.Add(robot);
        }

        public void aliveStatus()
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
