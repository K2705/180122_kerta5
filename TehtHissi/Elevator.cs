using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TehtHissi
{
    /// <summary>
    /// An elevator
    /// Contains the elevator's current floor
    /// Only allows changing the floor if the new floor is
    /// between the maximum and minimum floors the elevator can go
    /// </summary>
    class Elevator
    {
        public readonly int MinFloor = 1;
        public readonly int MaxFloor = 5;
        private int floor;
        /// <summary>
        /// The floor the elevator is on
        /// <throws>ArgumentOutOfRangeException when attempting to set floor not
        /// between the allowed minimum and maximum values</throws>
        /// </summary>
        public int Floor
        {
            get { return floor; }
            set
            {
                if (value < MinFloor)
                {
                    throw new ArgumentOutOfRangeException("floor", "Value too low.");
                }
                else if (value > MaxFloor)
                {
                    throw new ArgumentOutOfRangeException("floor", "Value too high.");
                }
                else floor = value;
            }
        }

        /// <summary>
        /// New Elevator
        /// </summary>
        /// <param name="minFloor">Lowest floor the elevator can go</param>
        /// <param name="maxFloor">Highest floor the elevator can go</param>
        public Elevator(int minFloor, int maxFloor)
        {
            this.MinFloor = minFloor;
            this.MaxFloor = maxFloor;
            this.floor = minFloor;
        }

    }
}
