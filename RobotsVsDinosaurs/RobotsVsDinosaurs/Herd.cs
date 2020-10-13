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

        public void AliveStatus()
        {
            foreach(Dinosaur dino in dinosaurs)
            {
                alive = false;
                if(dino.health == 0)
                {
                    alive = false;
                }else if(dino.health > 0)
                {
                    alive = true;
                    break;
                }
            }
            
        }
    }
}
