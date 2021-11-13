using System;
using System.Collections.Generic;

//SAFIU WAHEED
// 206454
//COMPUTER SCIENCE

namespace Anagrams
{
    class Anagrams
    {
        static public bool Anagram(string base_string, string test_string)
        {
            // Checking the letter of each word
            if (base_string.Length != test_string .Length) return false;

            // Spliting the test string into character
            char[] splited_test_string = test_string.ToCharArray();

            // Checking if the base string contain the test character
            foreach (var item in splited_test_string)
            {
                if (base_string.Contains(item))
                    base_string = base_string.Remove(base_string.IndexOf(item), 1);
                continue;
            }

            if (base_string.Length == 0) return true;
            else return false;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter the first world \t");
            string input_1 = Console.ReadLine().ToLower();

            Console.Write("Enter the second world \t");
            string input_2 = Console.ReadLine().ToLower();

            Console.WriteLine(Anagram(input_1, input_2));
            bool is_anagram = Anagram(input_1, input_2);

            if (is_anagram)
                Console.WriteLine("{0} and {1} are analgram", input_1, input_2);
            else Console.WriteLine("{0} and {1} are not analgram", input_1, input_2);

        }
    }
}
 