using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TehtTankki
{
    /// <summary>
    /// An armored fighting vehicle
    /// </summary>
    class Tank
    {
        public String Name { get; set; }
        public String Type { get; set; }
        private float SpeedMax = 100;

        private int crewCount;
        /// <summary>
        /// The number of crew on board the tank
        /// Must be between 2 and 6
        /// </summary>
        public int CrewCount
        {
            get
            {
                return this.crewCount;
            }
            set
            {
                if (value >= 2 && value <= 6)
                {
                    this.crewCount = value;
                }
            }
        }
        public float Speed { get; private set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name">The name of the tank</param>
        /// <param name="type">The type of the tank</param>
        public Tank(String name, String type)
        {
            this.Name = name;
            this.Type = type;
            this.CrewCount = 6;
            this.Speed = 0;
        }

        /// <summary>
        /// Default constructor, both name and type set to "default tank"
        /// </summary>
        public Tank() : this("generic tank", "generic tank")
        {
        }

        /// <summary>
        /// Increase the tank's speed
        /// </summary>
        /// <param name="newSpeed">the target speed</param>
        /// <returns>true if success, false if failure</returns>
        public bool AccelerateTo(int newSpeed)
        {
            if (newSpeed >= 0 && newSpeed <= SpeedMax && newSpeed > this.Speed)
            {
                this.Speed = newSpeed;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Decrease the tank's speed
        /// </summary>
        /// <param name="newSpeed">the target speed</param>
        /// <returns>true if success, false if failure</returns>
        public bool SlowTo(int newSpeed)
        {
            if (newSpeed >= 0 && newSpeed <= SpeedMax && newSpeed < this.Speed)
            {
                this.Speed = newSpeed;
                return true;
            }
            return false;
        }
        

    }
}
