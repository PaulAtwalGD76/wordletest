using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordleConsoleGame
{
    internal class Wordle
    {
        private string correctWord;
        private int maxAttemps;
        private string[] wordList;

        public Wordle(string[] newWordList, int maxAttempts)
        {
            this.wordList = newWordList;
            correctWord = GetRandomWord();
            this.maxAttemps = maxAttempts;
        }

        public int GetMaxAttempts()
        {
            return maxAttemps;
        }

        public string CheckGuess(string playerGuess)
        {
            char[] result = new char[correctWord.Length];
            // compare all characters in the player against the correct word
            //return the ones the got right in results
            for (int i = 0; i < correctWord.Length; i++)
            {
                if ( playerGuess[i] == correctWord[i] )
                {
                    result[i] = playerGuess[i];
                }

            //loop through playerGuess array
               else if (correctWord.Contains(playerGuess))
               {
                    result[i] = '?';
               }
               else
               {
                    result[i] = '*';
               }
            }
            //compare the playerGuess[i] == correctWord[1]
            return playerGuess;
        }

        private string GetRandomWord()
        {
            //create a new random number
            Random random = new Random();

            //get a random number (int)
            int randomnumber = random.Next(wordList.Length);

            return wordList[randomnumber];
        }

        public bool IsCorrectGuess(string playerGuess)
        {
            if (playerGuess == correctWord)
                return true;
                


           return false;
        }
    }
}
