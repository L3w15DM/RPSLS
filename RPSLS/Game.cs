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

            int numberOfPlayers = int.Parse(Console.ReadLine());

            if (numberOfPlayers > 2)
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
                
                Console.WriteLine("Player 1 please enter your name.");
                playerOne = new HumanPlayer("player 1");
                playerOne.name = Console.ReadLine();
                Console.WriteLine($"Thank you {playerOne.name}");
                playerTwo = new ComputerPlayer("computer");
                playerTwo.name = "Computer";
                Console.WriteLine($"{playerOne.name} vs {playerTwo.name}. FIGHT!");
            }
            else if (numberOfHumanPlayers == 2)
            {
                Console.WriteLine("Player 1 please enter your name.");
                playerOne = new HumanPlayer("player 1");
                playerOne.name = Console.ReadLine();
                Console.WriteLine("Player 2 please enter your name.");
                playerTwo = new HumanPlayer("player 2");
                playerTwo.name = Console.ReadLine();
                Console.WriteLine($"{playerOne.name} vs. {playerTwo.name}. FIGHT!");
            }
            
        }
        

        public virtual void CompareGestures()
        {
            if (playerOne.chosenGesture == "ROCK" && playerTwo.chosenGesture == "SCISSORS")
            {
                playerOne.score++;
                Console.WriteLine("You win!");
                
            }
            else if (playerOne.chosenGesture == "rock" && playerTwo.chosenGesture == "lizard")
            {
                playerOne.score++;
                Console.WriteLine("You Win!");
                
            }
            else if (playerOne.chosenGesture == "paper" && playerTwo.chosenGesture == "rock")
            {
                playerOne.score++;
                Console.WriteLine("You win!");
                

            }
            else if (playerOne.chosenGesture == "paper" && playerTwo.chosenGesture == "spock")
            {
                playerOne.score++;
                Console.WriteLine("You win!");
                

            }
            else if (playerOne.chosenGesture == "scissors" && playerTwo.chosenGesture == "paper")
            {
                playerOne.score++;
                Console.WriteLine("You win!");
                
            }
            else if (playerOne.chosenGesture == "scissors" && playerTwo.chosenGesture == "lizard")
            {
                playerOne.score++;
                Console.WriteLine("You win!");
                
            }
            else if (playerOne.chosenGesture == "lizard" && playerTwo.chosenGesture == "paper")
            {
                playerOne.score++;
                Console.WriteLine("You win!");
                
            }
            else if (playerOne.chosenGesture == "lizard" && playerTwo.chosenGesture == "spock")
            {
                playerOne.score++;
                Console.WriteLine("You win!");
                
            }
            else if (playerOne.chosenGesture == "spock" && playerTwo.chosenGesture == "rock")
            {
                playerOne.score++;
                Console.WriteLine("You win!");
                
            }
            else if (playerOne.chosenGesture == "spock" && playerTwo.chosenGesture == "scissors")
            {
                playerOne.score++;
                Console.WriteLine("You win!");
                
            }
            else if (playerOne.chosenGesture == playerTwo.chosenGesture)
            {
                Console.WriteLine("It's a tie");
            }
            else
            {
                playerTwo.score++;
                Console.WriteLine("You Lose!");

            }

        }

        public void DisplayGameWinner()
        {
            
            if (playerOne.score == 2)
            {
                Console.WriteLine($"{playerOne.name}, you win the game!");
            }
            else if (playerTwo.score == 2)
            {
                Console.WriteLine($"{playerTwo.name}, you win the game!");
            }
        }

        public void RunGame()
        {
            bool inPlay = true;

            WelcomeMessage();
            ChooseNumberOfHumanPlayers();
            CreatePlayerObjects(2);
            while (playerOne.score < 2 && playerTwo.score < 2)
            {
                playerOne.ChooseGesture();
                playerTwo.ChooseGesture();
                CompareGestures();
                Console.WriteLine($"{playerOne.name}: {playerOne.score}\n" + $"{playerTwo.name}: {playerTwo.score}");
            }
            
            DisplayGameWinner();

            Console.WriteLine("Would You Like to Play Again? Y/N?");
            string playAgain = Console.ReadLine();

            if (playAgain == "y")
            {
                RunGame();
            }
            else if (playAgain == "n")
            {
                Console.WriteLine("Thank you for playing!");
                inPlay = false;
            }
            else
            {
                Console.WriteLine("Enter valid response!");
                inPlay = false;
            }

        }
    }
}
