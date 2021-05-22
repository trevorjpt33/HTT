using System;
using System.Collections.Generic;

namespace HTT
{
    class GetMissingLetters
    {
        static void Main(string[] args)
        {
            string letters = "abcdefghijklmnopqrstuvwxyz";
            List<int> char_codes = new List<int>();
            for (int i = 0; i < letters.Length; i++)
            {
                char_codes.Add((int)letters[i]);
            }

            Console.Write("Enter a string with up to 256 characters: ");
            string user_str = (Console.ReadLine()).ToLower();

            if (user_str.Length <= 256)
            {
                for (int i = 0; i < user_str.Length; i++)
                {
                    int id = (int)user_str[i];
                    if (char_codes.Contains(id))
                    {
                        char_codes.Remove(id);
                    }
                }

                int num_letters_unused = char_codes.Count;
                Console.WriteLine("\nThere are " + num_letters_unused + " unused letters in your word:");
                for (int i = 0; i < num_letters_unused; i++)
                {
                    Console.Write((char)char_codes[i] + " ");
                }
            }
            else
            {
                Console.WriteLine("\nInvalid string. Too many characters.");
            }
        }
    }
}
