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
        public List<Dinosaur> herd;
        public bool alive;

        //ctor
        public Herd()
        {
            herd = new List<Dinosaur>();
            alive = true;
            Dinosaur trex = new Dinosaur("trex", 60, 100, 15);
            Dinosaur raptor = new Dinosaur("raptor", 45, 100, 6);
            Dinosaur triceratops = new Dinosaur("triceratops", 40, 100, 8);
            addDino(trex);
            addDino(raptor);
            addDino(triceratops);
        }
        //member methods
        public void addDino(Dinosaur dinosaur)
        {
            herd.Add(dinosaur);
        }

        public void aliveStatus()
        {
            foreach(Dinosaur dino in herd)
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
