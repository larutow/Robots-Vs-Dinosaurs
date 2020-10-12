﻿using System;
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
        public void doBattle(Fleet robots, Herd dinosaurs)
        {
            do
            {

                robots.aliveStatus();
                dinosaurs.aliveStatus();
            } while (robots.alive && dinosaurs.alive);
        }

        
    }
}
