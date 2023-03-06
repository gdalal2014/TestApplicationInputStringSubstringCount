using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApplicationInputStringSubstringCount
{
    public class ComputationSimple
    {
        //This is the simplest solution i could come up with, it is two embedded for loops, one finds the string, and
        //the other for loop finds the amount of times it shows up
        // I added this one in because this was what i started to get my problem solving solutions pumping. I knew this one would be the worst performing,
        // However i needed to write this one so that i could come up with the next two, so that i could solve a different problem, which was trying to make it perform better.

        public ComputationSimple()
        {
            
        }

        public static void computeSimple(string inputString, int inputLength)
        {
            string substringToFind = string.Empty;
            string substringToCompare = string.Empty;
            int howManyReps = 0;
            ArrayList alreadySearched = new ArrayList();

            for (int i = 0; i < inputString.Length; i++)
            {
                howManyReps = 0;
                if (inputString[i..].Length >= inputLength)
                {
                    substringToFind = inputString.Substring(i, inputLength);

                    for (int j = 0; j < inputString.Length; j++)
                    {
                        if (inputString[j..].Length >= inputLength)
                        {
                            if (!alreadySearched.Contains(inputString.Substring(j, inputLength)))
                            {
                                substringToCompare = inputString.Substring(j, inputLength);
                                if (string.Equals(substringToFind, substringToCompare))
                                {
                                    howManyReps++;
                                }
                                else
                                {
                                    continue;
                                }
                            }
                        }
                        else
                        {
                            continue;
                        }
                    }
                    if (!alreadySearched.Contains(inputString.Substring(i, inputLength)))
                    {
                        Console.WriteLine("String: " + substringToFind.ToString() + " has: " + howManyReps.ToString() + " Repetitions");
                    }

                    if (alreadySearched.Count > 0)
                    {
                        for (int k = 0; k < alreadySearched.Count; k++)
                        {
                            string valuePresentAndSearched = alreadySearched[k].ToString();
                            if (!string.Equals(valuePresentAndSearched.ToString(), substringToFind.ToString()))
                            {
                                alreadySearched.Add(substringToFind);
                            }

                        }
                    }
                    else
                    {

                        alreadySearched.Add(substringToFind);
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
