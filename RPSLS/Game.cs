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

            this.playerOne = playerTwo;
            this.playerTwo = playerTwo;
            
            
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
            int score = 0;

            while (playerOne.score <= 2 && playerTwo.score <=2)
            {
                if (playerOne.chosenGesture == "Rock" && playerTwo.chosenGesture == "Scissors" || playerTwo.chosenGesture == "Lizard")
                {
                    Console.WriteLine("You win!");
                    
                }
                else if (playerOne.chosenGesture == "Paper" && playerTwo.chosenGesture == "Rock" || playerTwo.chosenGesture == "Spock")
                {
                    Console.WriteLine("You win!");
                    
                }
                else if (playerOne.chosenGesture == "Scissors" && playerTwo.chosenGesture == "Paper" || playerTwo.chosenGesture == "Lizard")
                {
                    Console.WriteLine("You win!");
                }
                else if (playerOne.chosenGesture == "Lizard" && playerTwo.chosenGesture == "Paper" || playerTwo.chosenGesture == "Spock")
                {
                    Console.WriteLine("You win!");
                }
                else if (playerOne.chosenGesture == "Spock" && playerTwo.chosenGesture == "Scissors" || playerTwo.chosenGesture == "Paper")
                {
                    Console.WriteLine("You win!");
                }
                else if (playerOne.chosenGesture == playerTwo.chosenGesture)
                {
                    Console.WriteLine("It's a tie");
                }
                else
                {
                    Console.WriteLine("You Lose!");
                }

            }

        }

        public void DisplayGameWinner()
        {
            if (playerOne.score == 2)
            {
                Console.WriteLine("You win the game!");
            }
            else if (playerTwo.score == 2)
            {
                Console.WriteLine("You win the game!");
            }
        }

        public void RunGame()
        {
            WelcomeMessage();
            ChooseNumberOfHumanPlayers();
            playerOne.ChooseGesture();
            playerTwo.ChooseGesture();
            CompareGestures();
            
            

            
            
            
            
        }
    }
}
