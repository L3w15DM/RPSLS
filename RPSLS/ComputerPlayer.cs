using System;
namespace RPSLS
{
	internal class ComputerPlayer : Player
	{
		public ComputerPlayer(string name) : base(name)
        {
            this.name = "";
            
		}

        public override void ChooseGesture()
        {
            List<string> gestures = new List<string>
            {
                "ROCK",
                "PAPER",
                "SCISSORS",
                "LIZARD",
                "SPOCK"
            };

            Random rnd = new Random();
            int random = rnd.Next(gestures.Count);

            chosenGesture = gestures[random];
            chosenGesture.ToUpper();
            Console.WriteLine($"Computers choice: {gestures[random]}");
            
        }
    }
}

