using System;
namespace RPSLS
{
	internal class ComputerPlayer : Player
	{
		public ComputerPlayer(string name) : base(name)
        {
            
            
		}

        public override void ChooseGesture()
        {
            List<string> gestures = new List<string>
            {
                "rock",
                "paper",
                "scissors",
                "lizard",
                "spock"
            };

            Random rnd = new Random();
            int random = rnd.Next(gestures.Count);

            chosenGesture = gestures[random];
            chosenGesture.ToLower();
            Console.WriteLine($"Computers choice: {gestures[random]}");
            
        }
    }
}

