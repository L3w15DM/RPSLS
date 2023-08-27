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
            throw new NotImplementedException();
        }
    }
}

