namespace WordleConsoleGame
{
    internal class Player
    {
        public string GetGuess()
        {
            string guess = Console.ReadLine()?.ToLower();
            
            while (guess == null || guess.Length != 5)
            {
                Console.WriteLine("please enter a valid 5 letter guess");
                guess = Console.ReadLine()?.ToLower();
            }
            
            return guess;
        }
    }
}
