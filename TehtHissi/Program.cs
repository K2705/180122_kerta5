using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TehtHissi
{
    class Program
    {
        /// <summary>
        /// Two in one! It's an elevator and an audio amplifier!
        /// TODO: Bundle the text strings into the "elevator" object
        /// </summary>
        /// <param name="args">not used</param>
        static void Main(string[] args)
        {
            String STATE_TEXT = null;
            String QUESTION_TEXT = null;
            int MIN_NUMBER = 0;
            int MAX_NUMBER = 0;

            Console.Write("SELECT:\n1: Elevator\n2: Amplifier\nAnything else: Abort\n> ");
            String input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    STATE_TEXT = "Current floor: ";
                    QUESTION_TEXT = "Go to floor ";
                    MIN_NUMBER = 1;
                    MAX_NUMBER = 5;
                    break;
                case "2":
                    STATE_TEXT = "Amplifier volume is set to : ";
                    QUESTION_TEXT = "Give a new volume value ";
                    MIN_NUMBER = 0;
                    MAX_NUMBER = 100;
                    break;
                default:
                    Environment.Exit(0);
                    break;
            }

            Elevator dynamo = new Elevator(MIN_NUMBER, MAX_NUMBER);
            while (true)
            {
                Console.WriteLine(STATE_TEXT + dynamo.Floor);
                Console.Write(QUESTION_TEXT + "({0} - {1})\n> ", dynamo.MinFloor, dynamo.MaxFloor);
                int floor;
                int.TryParse(Console.ReadLine(), out floor);
                try
                {
                    dynamo.Floor = floor;
                }
                catch (ArgumentOutOfRangeException e)
                {
                    Console.WriteLine("Cannot set value {0}. Error:", floor);
                    Console.WriteLine(e.Message);
                }
            }

        }

        //private static void PretendToBeAmplifier()
        //{
        //    Elevator dynamo = new Elevator(0, 100);
        //    while (true)
        //    {
        //        Console.WriteLine(STATE_TEXT + dynamo.Floor);
        //        Console.Write("Give a new volume value ({0} - {1})\n> ", dynamo.MinFloor, dynamo.MaxFloor);
        //        int floor;
        //        int.TryParse(Console.ReadLine(), out floor);
        //        try
        //        {
        //            dynamo.Floor = floor;
        //        }
        //        catch (ArgumentOutOfRangeException e)
        //        {
        //            Console.WriteLine("Cannot set volume {0}. Error:", floor);
        //            Console.WriteLine(e.Message);
        //        }
        //    }
        //}

        //private static void PretendToBeElevator()
        //{
        //    Elevator dynamo = new Elevator(1, 5);
        //    while (true)
        //    {
        //        Console.WriteLine("Current floor: " + dynamo.Floor);
        //        Console.Write("Go to floor ({0} - {1})\n> ", dynamo.MinFloor, dynamo.MaxFloor);
        //        int floor;
        //        int.TryParse(Console.ReadLine(), out floor);
        //        try
        //        {
        //            dynamo.Floor = floor;
        //        }
        //        catch (ArgumentOutOfRangeException e)
        //        {
        //            Console.WriteLine("Cannot go to floor {0}. Error:", floor);
        //            Console.WriteLine(e.Message);
        //        }
        //    }
        //}
    }
}
