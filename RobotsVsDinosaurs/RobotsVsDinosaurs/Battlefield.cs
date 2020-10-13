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
        public Fleet robotFleet;
        public Herd dinosaurHerd;
        public Random rng = new Random();
        
        //ctor
        public Battlefield()
        {
            robotFleet = new Fleet();
            dinosaurHerd = new Herd();
        }

        //member methods

        public void VictoryMessage()
        {
            if(robotFleet.alive && !dinosaurHerd.alive)
            {
                Console.WriteLine("Robots win!");
            }else if (dinosaurHerd.alive && !robotFleet.alive)
            {
                Console.WriteLine("Dinosaurs win!");
            }
        }
        public void DoBattle()
        {
            do
            {
                    
                for (int i = 0; i < robotFleet.robots.Count; i++)
                {

                    Robot dinoTarget = dinosaurHerd.dinosaurs[i].AttackTarget(robotFleet);
                    
                    //tryAttack method for dinosaurs & robots
                    
                    dinosaurHerd.dinosaurs[i].TryAttack(dinoTarget, rng);
                    robotFleet.AliveStatus();

                    Dinosaur robotTarget = robotFleet.robots[i].AttackTarget(dinosaurHerd);
                    
                    robotFleet.robots[i].TryAttack(robotTarget);
                    dinosaurHerd.AliveStatus();
                    
                }
 
            } while (robotFleet.alive && dinosaurHerd.alive);

            VictoryMessage();
        }

        
    }
}
