using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheAdventuresOfCaptainBlad
{
    class Ship
    {
        public Ship()
        {

        }

        public int HULL;
        public int SPEED;
        public int CREW;

        public ShipLayout; 
        public Tile[,] SHIPGRID = new Tile[19, 4];


        //screw gitHub to the sticking place
        //hull - regenerates over time
        //crew  - doesn't regenerate	
        //once hull drops below 75%, crew start dying. If either one is 0, you die
        //speed - 
            //impacts how hard it is to hit your vessel (some)
            //*impacts how far you can go on the world map
        //maneuverbility - impacts how hard it is to hit your vessel (a lot)
        //
    }
}
