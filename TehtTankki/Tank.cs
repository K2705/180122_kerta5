using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TehtTankki
{
    class Tank
    {
        public String Name { get; set; }
        public String Type { get; set; }
        private float SpeedMax = 100;

        private int crewCount;
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

        public Tank(String name, String type)
        {
            this.Name = name;
            this.Type = type;
            this.CrewCount = 6;
            this.Speed = 0;
        }

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
