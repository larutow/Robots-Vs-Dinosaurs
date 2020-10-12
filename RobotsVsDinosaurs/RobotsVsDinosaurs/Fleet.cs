using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Fleet
    {
        //member variables
        public List<Robot> fleet;
        //ctor
        public Fleet()
        {
            fleet = new List<Robot>();
        }

        //member methods
        public void addRobo(Robot robot)
        {
            fleet.Add(robot);
        }
    }
}
