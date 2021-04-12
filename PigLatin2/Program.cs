using System;

namespace PigLatin2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Pig Latin Translator!");
            Console.WriteLine("Enter a word to be translated");
            string input = Console.ReadLine();
            string x = input.ToLower();
            string pig;
            const string vowels = "aeiou";
            string a;
            string b;
            int pos;
            {
                foreach (string word in x.Split())
                {
                    a = word.Substring(0, 1);
                    b = word.Substring(1, word.Length, -1);
                    pos = vowels.IndexOf(a);
                    if (pos == -1)
                    {
                        pig = b + a + "ay";
                    }
                    else
                    {
                        pig = word + "way";
                    }
                    
                }
                return (pig);
            }

        }
    }
}


