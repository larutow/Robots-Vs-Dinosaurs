using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Herd
    {
        //member variables
        public List<Dinosaur> dinosaurs;
        public bool alive;

        //ctor
        public Herd()
        {
            dinosaurs = new List<Dinosaur>();
            alive = true;
            Dinosaur trex = new Dinosaur("trex", 60, 100, 15);
            Dinosaur raptor = new Dinosaur("raptor", 45, 100, 6);
            Dinosaur triceratops = new Dinosaur("triceratops", 40, 100, 8);
            AddDino(trex);
            AddDino(raptor);
            AddDino(triceratops);
        }
        //member methods
        public void AddDino(Dinosaur dinosaur)
        {
            dinosaurs.Add(dinosaur);
        }

        public void RemoveDino(Dinosaur dinosaur)
        {
            dinosaurs.Remove(dinosaur);
        }

        public void Attack(Fleet robotFleet, Random rng)
        {
            int attackDinoIndex = rng.Next(0, dinosaurs.Count);
            if(dinosaurs.Count > 0)
            {
            Robot dinoTarget = dinosaurs[attackDinoIndex].AttackTarget(robotFleet);

            //tryAttack method for dinosaurs & robots

            dinosaurs[attackDinoIndex].TryAttack(dinoTarget, rng);
            robotFleet.AliveStatus();
            }
        }

        public void AliveStatus()
        {
            int numOfDinosAlive = dinosaurs.Count;
            
            for(int i = 0; i < numOfDinosAlive; i++)
            {
                if(dinosaurs[i].health == 0)
                {
                    RemoveDino(dinosaurs[i]);
                    break;
                }
            }
        }
    }
}
