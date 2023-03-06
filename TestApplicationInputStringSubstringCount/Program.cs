  using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

namespace TestApplicationInputStringSubstringCount
{
  
    public class Program
    {
        /**
        Before getting started, i would like to list the assumptions that i made:
        1. That this would be a console application where the application inputs (arguments) would be given by the user through command line ie (dotnet run inputstring patternlength)
        2. That an input would not be required from the console where Console.readline() argument would be needed
        3. I have provided a way to bypass the error handling at the beginning by allowing the user to hardcode the input string and the pattern length (inputInteger) values 
        4. When a command line input is given the first argument will be the string and the second argument the pattern

        **/
        static void Main(string[] args)
        {
            ExecuteProgram(args);
        }

        public static void ExecuteProgram(string[] args)
        {
            //These values can be changed 
            string inputString = "akldjfaladjfl;aalkadfadfdajdlafjakdjfl"; //Default value is string.Empty
            int inputInteger = 3; //Default value is 0
                                  //string inputString = string.Empty; //Default Value
                                  //int inputInteger = 0; //Default Value
            if (inputString == string.Empty || inputInteger == 0)
            {
                if (args == null || args.Length < 2)
                {
                    Console.WriteLine("Please Input a String and an Integer");
                    Environment.Exit(1);
                }


                else if (args[0].GetType() != typeof(string))
                {
                    Console.WriteLine("First Argument must be a String");
                    Environment.Exit(1);

                }
                else if (!int.TryParse(args[1].ToString(), out inputInteger))
                {
                    Console.WriteLine("Second Argument must be an Integer Value");
                    Environment.Exit(1);

                }
                else
                {
                    inputString = args[0].ToString();
                    inputInteger = int.Parse(args[1].ToString());

                }
            }

            ComputationEasy.Compute(inputString, inputInteger);
            Console.WriteLine("");
            ComputationRegex.ComputeUsingRegex(inputString, inputInteger);
            Console.WriteLine("");
            //var computeValuesSimple = new ComputationSimple(); //This one takes the most memory and if the string is long it might not work
            //computeValuesSimple.ComputeSimple(inputString, inputInteger); 
            ComputationWithLinq.ComputeWithLinqHelper(inputString, inputInteger);

        }
    }

    



}