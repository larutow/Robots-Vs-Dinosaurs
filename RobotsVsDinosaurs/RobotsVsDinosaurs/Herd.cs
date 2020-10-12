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

        //ctor
        public Herd()
        {
            herd = new List<Dinosaur>();
            Dinosaur trex = new Dinosaur("trex", 60, 100, 20);
            Dinosaur raptor = new Dinosaur("raptor", 45, 100, 4);
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
    }
}
