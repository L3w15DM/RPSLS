namespace RPSLS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HumanPlayer player = new HumanPlayer("player");
            ComputerPlayer artificalInteeligence = new ComputerPlayer("computer");
            Game game = new Game();
            game.RunGame();
        }
    }
}