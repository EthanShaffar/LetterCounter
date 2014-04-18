using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetterCounter
{
    class Program
    {
        /// <summary>
        /// Letter Counter:
        /// This process will take a string, read each character in the string, then based on what letter is
        /// called within the parameters, print out the amount of times the letter is used.
        /// Also, it will print out how many were upper and lower case.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            LetterCounter("i", "I love bicuits and gravey! It's the best breakfast EVER!");
            LetterCounter("n", "Never gonna give you up! Never gonna let you down!");
            LetterCounter("s", "Sally sells seashells down by the sea shore. She's from Sussex.");

            Console.ReadKey();
        }
        static void LetterCounter(string let, string inString)
        {
            //Need to make variables for counters and shortcut typing.
            var sen = inString;
            var bCount = 0;
            var lCount = 0;
            foreach (char s in sen) //for each letter in sentence, this loop will check for....
            {
                var C = s.ToString(); //Convert letter to own string
                var bigLet = let.ToUpper();//Convert the inputed letter to uppercase here too
                if (C == bigLet) // Check here if it matches any upper case in the sentence
                {
                    bCount += 1;
                }
                
                var lowLet = let.ToLower();//check here uf letter matches an lower case.
                if (C == lowLet)
                {
                    lCount += 1;
                }
            }
            Console.WriteLine("Input: " + inString);
            Console.WriteLine("Number of lowercase " + let + "'s found: " + lCount);
            Console.WriteLine("Number of UPPERCASE " + let + "'s found: " + bCount);
            Console.WriteLine("Total Number of " + let + "'s fount: " + (bCount + lCount));
            Console.WriteLine(" ");
        }
    }
}
