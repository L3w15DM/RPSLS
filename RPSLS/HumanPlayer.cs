using System;
namespace RPSLS
{
	internal class HumanPlayer : Player
	{
        

        public HumanPlayer(string name) : base(name)
        {
            
        }



        public override void ChooseGesture()
        {

            Console.WriteLine("Choose your gesture: ROCK, PAPER, SCISSORS, LIZARD, or SPOCK!");

            
            chosenGesture = Console.ReadLine();
            


            Console.WriteLine($"{name}'s choice: {chosenGesture.ToLower()}");


        }
    }
}

