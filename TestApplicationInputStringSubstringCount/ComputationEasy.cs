namespace TestApplicationInputStringSubstringCount
{
    public class ComputationEasy
    {
        //This one is a simple one because the Dictionary is very easy to use and the value can be updated very easily
        //As find the key in the dictionary is an easy thing to do. Also we don't have to worry about repetition and adding
        //multiple values of the same string because the key is unique

        public ComputationEasy()
        {
            
        }
        public void compute(string inputString, int inputLength)
        {
            Dictionary<string, int> substringsPresent = new Dictionary<string, int>();
            for (int i = 0; i < inputString.Length; i++)
            {
                if (inputString.Substring(i).Length >= inputLength)
                {
                    string subInputString = inputString.Substring(i, inputLength);
                    if (!substringsPresent.ContainsKey(subInputString))
                    {
                        substringsPresent.Add(subInputString, 1);
                    }
                    else
                    {
                        int valuePresent = substringsPresent.GetValueOrDefault(subInputString);
                        valuePresent++;
                        substringsPresent[subInputString] = valuePresent;

                    }
                }
                else
                {
                    continue;
                }


            }

            //The foreach is an easy way to iterate through the dictionary without having to build a for loop

            foreach (var item in substringsPresent)
            {
                string keyValue = item.Key;
                int intValue = item.Value;
                Console.WriteLine("String: " + keyValue.ToString() + " has: " + intValue.ToString() + " Repetitions");
            }

        }
    }

}
