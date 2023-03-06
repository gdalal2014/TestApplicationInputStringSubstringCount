using System.Collections;
using System.Text.RegularExpressions;

namespace TestApplicationInputStringSubstringCount
{
    public class computationRegex
    {
        //The last one i tried was the regex one, i am more familiar with regex in Oracle,
        //However i found that it was very similary between the two. Although a for loop needed to be used
        //the regex proved to be the simplest code of all three computations i created

        public computationRegex()
        {
            
        }
        public static void ComputeUsingRegex(string inputString, int inputLength)
        {
            var alreadySearched = new ArrayList();
            for (int i = 0; i < inputString.Length; i++)
            {
                if (inputString[i..].Length >= inputLength)
                {

                    string subInputString = inputString.Substring(i, inputLength);
                    if (!alreadySearched.Contains(subInputString))
                    {
                        subInputString = Regex.Escape(subInputString);
                        int frequencyValue = Regex.Matches(inputString, subInputString).Count;

                        alreadySearched.Add(subInputString);
                        Console.WriteLine($"String: {subInputString}  has: {frequencyValue} Repetitions");
                    }
                    else
                    {
                        continue;
                    }


                }
                else
                {
                    continue;
                }

            }
        }
    }
}
