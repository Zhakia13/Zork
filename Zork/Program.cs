using System;

namespace Zork
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Zork!");

            Commands command = Commands.UNKNOWN;
            while (command != Commands.QUIT)
            {
                Console.Write("> ");
                command = ToCommand(Console.ReadLine().Trim());

                string outputString = " ";
                switch (command)
                {
                    case Commands.QUIT:
                        Console.WriteLine("Thank you for playing!"); 
                        break;

                    case Commands.LOOK:
                        Console.WriteLine("This is an open field west of a white house, with a boarded front door.\n A rubber mat saying 'Welcome to Zork!' lies by the door.");
                        break;

                    case Commands.NORTH:
                    case Commands.SOUTH:
                    case Commands.EAST:  
                    case Commands.WEST:
                        Console.WriteLine("You moved " + command);
                        break;

                    default:
                        Console.WriteLine("Unknown command.");
                        break;
                }
                Console.WriteLine(outputString);
            }
        }
        private static Commands ToCommand(string commandString) => (Enum.TryParse<Commands>(commandString, true, out Commands result) ? result : Commands.UNKNOWN);

    }
}
    

