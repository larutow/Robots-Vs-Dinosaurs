using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Battlefield
    {
        //member variables
        public Fleet robots;
        public Herd dinosaurs;
        
        //ctor
        public Battlefield()
        {
            robots = new Fleet();
            dinosaurs = new Herd();
        }

        //member methods

        public void VictoryMessage()
        {
            if(robots.alive && !dinosaurs.alive)
            {
                Console.WriteLine("Robots win!");
            }else if (dinosaurs.alive && !robots.alive)
            {
                Console.WriteLine("Dinosaurs win!");
            }
        }
        public void DoBattle(Fleet robots, Herd dinosaurs)
        {
            do
            {
                    
                for (int i = 0; i < robots.fleet.Count; i++)
                {

                    Robot dinoTarget = dinosaurs.herd[i].attackTarget(robots);
                    if(dinosaurs.herd[i].health > 0)
                    {
                       dinosaurs.herd[i].Attack(dinoTarget);
                    }
                    robots.aliveStatus();

                    Dinosaur robotTarget = robots.fleet[i].attackTarget(dinosaurs);
                    if (robots.fleet[i].health > 0)
                    {
                       robots.fleet[i].Attack(robotTarget);
                    }
                    dinosaurs.aliveStatus();

                    Console.WriteLine("");
                    
                }
 
            } while (robots.alive && dinosaurs.alive);

            VictoryMessage();
        }

        
    }
}
