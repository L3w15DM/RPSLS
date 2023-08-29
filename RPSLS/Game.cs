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

            int numberOfHumanPlayers = int.Parse(Console.ReadLine());

            while (numberOfHumanPlayers != 1 && numberOfHumanPlayers != 2)
            {
                Console.WriteLine("Invalid input!! Please choose 1 or 2 players!");
                numberOfHumanPlayers = int.Parse(Console.ReadLine());
            }
            return numberOfHumanPlayers;
        }

        public void CreatePlayerObjects(int numberOfHumanPlayers)
        {
            if (numberOfHumanPlayers == 1)
            {
                playerOne = new HumanPlayer("player 1");
                playerTwo = new ComputerPlayer("computer");
            }
            else if (numberOfHumanPlayers == 2)
            {
                playerOne = new HumanPlayer("player 1");
                playerTwo = new HumanPlayer("player 2");
            }
        }

        public virtual void CompareGestures()
        {
            Console.WriteLine("Please choose a gesture: ROCK, PAPER, SCISSORS, LIZARD, OR SPOCK!");
            
            
           




        }

        public void DisplayGameWinner()
        {

        }

        public void RunGame()
        {
            WelcomeMessage();
            ChooseNumberOfHumanPlayers();
            CompareGestures();
            
            
            
        }
    }
}
