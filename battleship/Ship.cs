using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace battleship
{
    class Ship
    {
        //Member Variables
        public string type;
        public int length;
        //Constructor
        public Ship(string type, int length)
        {
            this.type = type;
            this.length = length;
        }
        //Member Methods
        public void ShipHit()
        {
            length--;
        }
    }
}
