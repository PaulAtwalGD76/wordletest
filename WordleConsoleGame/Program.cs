namespace WordleConsoleGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create a word list for the game
            string[] wordList =
{
                "mommy",
                "doggy",
                "bread",
                "break",
            };
            // create a new game and start it
            var game = new Game(wordList);
            game.StartGame();
        }
    }
}
