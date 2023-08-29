using System;
namespace RPSLS
{
	internal class ComputerPlayer : Player
	{
		public ComputerPlayer(string name) : base(name)
        {
            this.name = "computer";
            
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

            Random rnd = new Random();
            int random = rnd.Next(gestures.Count);

            chosenGesture = gestures[random];

            Console.WriteLine($"Computers choice: {gestures[random]}");
            
        }
    }
}

