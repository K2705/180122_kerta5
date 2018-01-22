using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TehtTankki
{
    class TestTank
    {
        static void Main(string[] args)
        {
            Tank tank = new Tank();
            PrepTank(tank);
            DriveTank(tank);
        }

        private static void DriveTank(Tank tank)
        {
            bool running = true;
            while (running)
            {
                Console.WriteLine();
                Console.WriteLine("╓─│─╖    The {0} \"{1}\"", tank.Type, tank.Name);
                Console.WriteLine("╠═│═╣    Crew: {0}", tank.CrewCount);
                Console.WriteLine("║╒╬╕║    Current speed: {0}", tank.Speed);
                Console.WriteLine("║└─┘║    ");
                Console.WriteLine("╚═══╝    ");
                Console.WriteLine();
                Console.WriteLine("Available commands:");
                Console.WriteLine("[1] Accelerate");
                Console.WriteLine("[2] Slow");
                Console.WriteLine("[3] Change crew");
                Console.WriteLine("[4] Rename tank");
                Console.WriteLine("[Q] Quit");

                String input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        //accelerate
                        Console.WriteLine("Enter target speed\n> ");
                        int newSpeed;
                        if (int.TryParse(Console.ReadLine(), out newSpeed) && tank.AccelerateTo(newSpeed))
                        {
                            Console.WriteLine("You accelerate.");
                        }
                        else
                        {
                            Console.WriteLine("You can't do that.");
                        }
                        break;
                    case "2":
                        //slow
                        Console.WriteLine("Enter target speed\n> ");
                        if (int.TryParse(Console.ReadLine(), out newSpeed) && tank.SlowTo(newSpeed))
                        {
                            Console.WriteLine("You slow down.");
                        }
                        else
                        {
                            Console.WriteLine("You can't do that.");
                        }
                        break;
                    case "3":
                        //change crew
                        Console.WriteLine("Enter new crew size\n> ");
                        int newCrew;
                        if (int.TryParse(Console.ReadLine(), out newCrew))
                        {
                            tank.CrewCount = newCrew;
                        }
                        break;
                    case "4":
                        //rename
                        Console.WriteLine("Enter new tank name");
                        tank.Name = Console.ReadLine();
                        Console.WriteLine("You rename your tank to \"{0}\"", tank.Name);
                        break;
                    case "q":
                    case "Q":
                        //quit
                        running = false;
                        Console.WriteLine("Exiting . . .");
                        break;

                }
            }
        }


        private static void PrepTank(Tank tank)
        {
            bool success = false;
            Console.WriteLine("Enter tank name");
            while (!success)
            {
                Console.Write("> ");
                String name = Console.ReadLine();
                if ( name.Length > 0)
                {
                    tank.Name = name;
                    Console.WriteLine("Name set to \"{0}\"", tank.Name);
                    success = true;
                }
            }
            success = false;

            String[] tankTypes = { "Panther", "T-34", "M4 Sherman" };

            Console.WriteLine("\nSelect tank type");
            Console.WriteLine("[1] " + tankTypes[0]);
            Console.WriteLine("[2] " + tankTypes[1]);
            Console.WriteLine("[3] " + tankTypes[2]);
            while (!success)
            {
                Console.Write(">");
                int result;
                if (int.TryParse(Console.ReadLine(), out result))
                {
                    if (result >= 1 && result <= 3)
                    {
                        tank.Type = tankTypes[result - 1];
                        Console.WriteLine("Type {0} selected", tank.Type);
                        success = true;
                    }
                }
            }
            success = false;

            Console.WriteLine("Select crew size (2-6)");
            while (!success)
            {
                Console.Write(">");
                int result;
                if (int.TryParse(Console.ReadLine(), out result))
                {
                    if (result >= 2 && result <= 6)
                    {
                        tank.CrewCount = result;
                        Console.WriteLine("Crew size set to " + tank.CrewCount);
                        success = true;
                    }
                }
            }
        }
    }
}
