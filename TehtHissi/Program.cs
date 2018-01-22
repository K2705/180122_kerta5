using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TehtHissi
{
    class Program
    {
        static void Main(string[] args)
        {
            Elevator dynamo = new Elevator(1, 5);
            while (true)
            {
                Console.WriteLine("Current floor: " + dynamo.Floor);
                Console.Write("Go to floor ({0} - {1})\n> ", dynamo.MinFloor, dynamo.MaxFloor);
                int floor;
                int.TryParse(Console.ReadLine(), out floor);
                try
                {
                    dynamo.Floor = floor;
                }
                catch (ArgumentOutOfRangeException e)
                {
                    Console.WriteLine("Cannot go to floor {0}. Error:", floor);
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
