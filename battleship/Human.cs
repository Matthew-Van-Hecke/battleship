using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace battleship
{
    class Human : Player
    {
        //Member Variables

        //Constructor
        public Human(Random random)
            :base (random)
        {

        }

        //Member Methods
        public override void PlaceAShip(int shipLength)
        {
            int yCoordinateFirstCorner;
            bool yValidResponse;
            int xCoordinateSecondCorner;
            //Pick the inner corner of where the ship should be placed (meaning that the other end of the ship should be at the same position along one axis and a position that is 1 short of being current position plus length of ship along the other axis)
            Console.WriteLine("Please choose where you would like to position the inner corner of your ship. Choose Y coordinate, hit enter, then choose X coordinate.");
            yValidResponse = int.TryParse(Console.ReadLine(), out yCoordinateFirstCorner);
            //Pick position of other end of ship. There will only be two options.
            
            //Encode those poistions on player's board with a string unique to the ship placed on them.
        }
        public int PickCoordinate()
        {
            bool validResponse = true;
            int pickedInt;
            do
            {
                if (!validResponse)
                {
                    Console.WriteLine("Invalid response. Please try again.");
                }
                validResponse = int.TryParse(Console.ReadLine(), out pickedInt);
            } while (!validResponse);
            return pickedInt;
        }
    }
}
