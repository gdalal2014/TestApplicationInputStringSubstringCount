using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApplicationInputStringSubstringCount
{
    public static class ComputationWithLinq
    {

        public static void ComputeWithLinqHelper(string inputString, int inputLength)
        {
            var listOfSubstrings = new List<string>();
            for (int i = 0; i < inputString.Length; i++)
            {
                if (inputString[i..].Length >= inputLength)
                {
                    var substringValueToFind = inputString.Substring(i, inputLength);
                    if (listOfSubstrings.Contains(substringValueToFind)) continue;
                    var frequencyValue = inputString.Select((charValue, index) => inputString[index..]).Count(substring => substring.StartsWith(substringValueToFind));
                    listOfSubstrings.Add(substringValueToFind);
                    Console.WriteLine($"String: {substringValueToFind} has: {frequencyValue} Repetitions");
                }


            }
        }
    }
}
    

