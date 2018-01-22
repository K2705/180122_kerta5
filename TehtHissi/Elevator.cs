using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TehtHissi
{
    class Elevator
    {
        public readonly int MinFloor = 1;
        public readonly int MaxFloor = 5;
        private int floor;
        public int Floor
        {
            get { return floor; }
            set
            {
                if (value >= MinFloor && value <= MaxFloor)
                {
                    floor = value;
                }
            }
        }

        public Elevator(int minFloor, int maxFloor)
        {
            this.MinFloor = minFloor;
            this.MaxFloor = maxFloor;
            this.floor = minFloor;
        }

    }
}
