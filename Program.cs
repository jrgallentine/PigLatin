using System;
using System.Text;

namespace PigLatin
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
            Console.Clear();
            
            string word;
            string lowerWord;
            string cont;

            Console.WriteLine("Pig Latin Translator");
            Console.Write("Word you'd like translated: ");
            word = Console.ReadLine();
            lowerWord = word.ToLower();

            Console.WriteLine(lowerWord);

            string oink = PigTalk(lowerWord);

            if (oink == "-1")
            {
                Console.WriteLine("No vowels...no pig talk for you.");
            }
            else
            {
                Console.WriteLine(oink);
            }
                Console.Write("Another one? (y/n): ");
                cont = Console.ReadLine();

             if (cont != "y")
                {
                    break;
                }
            }
        }

        static bool Vowel(char v)
        {
            return (v == 'a' || v == 'e' || v == 'i' || v == 'o' || v == 'u');
        }

        static string PigTalk(string pig)
        {
            int len = pig.Length;
            int vowelPos = -1;
            for (int i = 0; i < len; i++)
            {
                if (Vowel(pig[i]))
                {
                    vowelPos = i;
                    break;
                }          
            }
            if (vowelPos == -1)
            { 
                return "-1"; 
            }
            if (Vowel(pig[0]))
            {
                return pig + "way";
            }

            return pig.Substring(vowelPos) +
                   pig.Substring(0, vowelPos) + "ay";
            
            
        }
    }
}
