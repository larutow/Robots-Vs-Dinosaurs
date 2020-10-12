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
        }
        //member methods
        public void addDino(Dinosaur dinosaur)
        {
            herd.Add(dinosaur);
        }
    }
}
