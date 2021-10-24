using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Problem
{
    class VowelORConsoant
    {
        public Char word;

        public void Check ()
        {
            Console.WriteLine("Please Enter an Alphabet (A-Z or a-z)");
            word = Convert.ToChar(Console.ReadLine());

            if (word == 'a' || word == 'e' || word == 'i' || word == 'o' || word == 'u'
                || word == 'A' || word == 'E' || word == 'I' || word == 'O' || word == 'U')
            {
                Console.WriteLine(word + " is an Vowel");
            }
            else
            {
                Console.WriteLine(word + " is a Consonant");
            }


        }
    }
}
