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
            if(robotFleet.robots.Count > 0)
            {
                Console.WriteLine("Robots win!");
            }else if (dinosaurHerd.dinosaurs.Count > 0)
            {
                Console.WriteLine("Dinosaurs win!");
            }
        }
        public void DoBattle()
        {
            do
            {
                dinosaurHerd.Attack(robotFleet, rng);
                robotFleet.Attack(dinosaurHerd, rng);

            } while (robotFleet.robots.Count > 0 && dinosaurHerd.dinosaurs.Count > 0);

            VictoryMessage();
        }

        
    }
}
