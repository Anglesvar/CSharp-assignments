using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace Program
{
    class Utility
    {
        public static string LastWord(int position, string stringVariable, char charToParse)
        {
            // Splitting words based on the charToParse character.
            string[] words = stringVariable.Split(charToParse);
            //retrieving the word present at the given position
            string result = words[position];
            if (result != null && position < stringVariable.Length)
                return result;
            else
                return "There is no word in the position given.";
        }

        public ArrayList GetPalindromes(ArrayList words)
        {
            ArrayList palindromicWords = new ArrayList();
            foreach(string word in words){
                if (word.SequenceEqual( word.Reverse()))
                    palindromicWords.Add(word);
            }
            return palindromicWords;
        }

    }
}
