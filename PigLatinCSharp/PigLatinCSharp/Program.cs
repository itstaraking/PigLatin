using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigLatinCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // give user instruction
            Console.WriteLine("Enter a sentence and I will translate it to Pig Latin!");

            // create variable to hold user input
            string input = Console.ReadLine();

            // create a delimiter to remove spaces
            char[] delim = {' ', '.'};

            // tokenize the string
            string[] tokens = input.Split(delim);

            foreach(string str in tokens)
            {
                // convert string to char array
                str.ToCharArray();

                // variable to hold "ay" suffix
                string suffix = "ay";

                // char to hold first letter
                char letter = str[0];

                // create new string
                string newWord = str[1].ToString() + str.Substring(2) + letter + suffix;

                // display new string
                Console.WriteLine(newWord);
            } 

            // hold screen open
            Console.Read();

        }
    }
}
