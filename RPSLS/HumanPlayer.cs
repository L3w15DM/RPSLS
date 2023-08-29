using System;
namespace RPSLS
{
	internal class HumanPlayer : Player
	{
        public HumanPlayer(string name) : base(name)
        {
            this.name = name;
        }



        public override void ChooseGesture()
        {


            List<string> gestures = new List<string>
            {
                "rock",
                "paper",
                "scrissors",
                "lizard",
                "spock"
            };

            Console.WriteLine("Choose your gesture:");


            for (int i = 0; i < gestures.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {gestures[i]}");
            }

            int choiceIndex = int.Parse(Console.ReadLine()) - 1;

            while (choiceIndex < 0 || choiceIndex >= gestures.Count)
            {
                Console.WriteLine("Invalid input. Choose a valid gesture.");
                choiceIndex = int.Parse(Console.ReadLine()) - 1;
                
            }

            
        }
    }
}

