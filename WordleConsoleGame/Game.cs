using System.Globalization;

namespace WordleConsoleGame
{
    internal class Game
    {
        private Wordle wordle;
        private Player player;

        public Game(string[] wordList)
        {
            player = new();
            wordle = new Wordle(wordList, 20);
        }

        public void StartGame()
        {
            //get max attemps
            int attempts = wordle.GetMaxAttempts();
            bool success = false;
            string result = "XXXXX";

            while(attempts  > 0 && !success)
            {
                DrawHeader();
                DrawPlayerGuessState(result);
                Console.WriteLine("\n\tEnter your 5-letter guess");
                
                var playerGuess = player.GetGuess();
                /// validate the guess
                result = wordle.CheckGuess(playerGuess);

                if(wordle.IsCorrectGuess(playerGuess))
                {
                    success = true;

                    Console.WriteLine("congrats you win at life now :p");
                }
                else
                {
                    attempts--;
                    Console.WriteLine("you have"  );
                }
            }

            if (!success)
            {
                Console.WriteLine("GETOUT");
            }

        }

        private void DrawPlayerGuessState(string result)
        {
            Console.WriteLine("\n\t" + result);
            Console.WriteLine("\n\tYou have [x] guesses remaining!");
        }

        private void DrawHeader()
        {
            Console.Clear();

            Console.WriteLine("\n\n\t********************************");
            Console.WriteLine("\t*                              *");
            Console.WriteLine("\t****** Welcome to Wordle *******");
            Console.WriteLine("\t*                              *");
            Console.WriteLine("\t********************************");
        }
    }
}
