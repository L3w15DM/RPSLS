﻿using System;
namespace RPSLS
{
	internal class HumanPlayer : Player
	{
        

        public HumanPlayer(string name) : base(name)
        {
            name = "";
        }



        public override void ChooseGesture()
        {

            Console.WriteLine("Choose your gesture: ROCK, PAPER, SCISSORS, LIZARD, or SPOCK!");

            chosenGesture = Console.ReadLine();

            Console.WriteLine($"Player choice: {chosenGesture}");


        }
    }
}

