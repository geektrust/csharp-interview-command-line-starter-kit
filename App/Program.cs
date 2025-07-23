using System;
using System.Collections.Generic;

namespace App
{
    public class Program
    {
        /*
         ***********************************************
         * This is the driver code. Don't change it!!!
         * *********************************************
         */
        public static void Main(string[] args)
        {
            /*
             * Format of the 'args' array: [`<COMMAND_NAME_1> <ARG1> <ARG2> .. <ARG N>`, `<COMMAND_NAME_2> <ARG1> <ARG2> .. <ARG N>`]
             *  Example: ["PLACE_ORDER 101 Apple 5", "TOTAL_COST 101"]
             * 
             * The code evaluator will execute this code by using the command 
             * dotnet run -- "PLACE_ORDER 101 Apple 5" "TOTAL_COST 101"
             * 
             * We loop through the list of commands passed in as input arguments and handle each one of them
             */
            foreach (var input in args)
            {
                Handle(input);
            }
        }

        /*
         * This method should parse each input and assign it into different variables.
         * 
         * The value of the function parameter "input" will be of the format - "`<COMMAND_NAME_1> <ARG1> <ARG2> .. <ARG N>".
         * We split the string and retrieve the input data appropriately into the variable inputListForOneCommand. 
         */
        private static void Handle(string input)
        {
            var inputListForOneCommand = input.Trim().Split(' ');
            var command = inputListForOneCommand[0]; // command name
            Console.WriteLine(command); // Example: "PLACE_ORDER" or "TOTAL_COST"

            var arg1 = inputListForOneCommand.Length > 1 ? inputListForOneCommand[1] : null;
            Console.WriteLine(arg1); // Example: "101"

            /*
             * Implementation of the solution should begin after this. 
             * Please make sure you convert the variables into appropriate data types required for the solution.
             */
        }
    }
}
