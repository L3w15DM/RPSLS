using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    internal class Game
    {
        //Member Variabes (HAS A)
        public Player playerOne;
        public Player playerTwo;

        //Constructor
        public Game()
        {
            this.playerOne = null;
            this.playerTwo = null;
        }

        //Member Methods (CAN DO)
        public void WelcomeMessage()
        {
            Console.WriteLine("Welcome to RPSLS! Here are the rules:\n" +
                "Explanation of game rules\n" +
                "Rock crushes Scissors\n" +
                "Scissors cuts Paper \n" +
                "Paper covers Rock\n" +
                "Rock crushes Lizard\n" +
                "Lizard poisons Spock\n" +
                "Spock smashes Scissors\n" +
                "Scissors decapitates Lizard\n" +
                "Lizard eats Paper\n" +
                "Paper disproves Spock\n" +
                "Spock vaporizes Rock\n" +
                "Best two out of three WINS the Game!!");
        }

        public int ChooseNumberOfHumanPlayers()
        {
            Console.WriteLine("Input number of players!");

            int numberOfPlayers = int.Parse(Console.ReadLine());

            while (numberOfPlayers != 1 && numberOfPlayers != 2)
            {
                Console.WriteLine("Invalid input!! Please choose 1 or 2 players!");
                numberOfPlayers = int.Parse(Console.ReadLine());
            }
            return numberOfPlayers;
        }

        public void CreatePlayerObjects(int numberOfHumanPlayers)
        {
            if (numberOfHumanPlayers == 1)
            {
                playerOne = new HumanPlayer("Player 1");
                playerTwo = new ComputerPlayer("Computer");
            }
            else if (numberOfHumanPlayers == 2)
            {
                playerOne = new HumanPlayer("Player 1");
                playerTwo = new HumanPlayer("Player 2");
            }
        }

        public virtual void CompareGestures()
        {

        }

        public void DisplayGameWinner()
        {

        }

        public void RunGame()
        {
            WelcomeMessage();
            ChooseNumberOfHumanPlayers();
        }
    }
}
