using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class DinoAttack
    {
        //member variables
        public string type;
        public int attackPower;

        //ctor
        public DinoAttack(string type, int attackPower)
        {
            this.type = type;
            this.attackPower = attackPower;
        }
        //member methods
    }
}
