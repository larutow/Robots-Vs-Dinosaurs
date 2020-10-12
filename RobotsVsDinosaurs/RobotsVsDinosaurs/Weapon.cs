using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Weapon
    {
        //member variables
        public string weaponType;
        public int attackPower;

        //ctor
        public Weapon(string weaponType, int attackPower)
        {
            this.weaponType = weaponType;
            this.attackPower = attackPower;
        }
        //member methods

    }
}
