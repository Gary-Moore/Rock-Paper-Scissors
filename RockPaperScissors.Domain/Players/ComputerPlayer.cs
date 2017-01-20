using RockPaperScissors.Domain.SIgns;
using System;

namespace RockPaperScissors.Domain.Players
{
    public class ComputerPlayer : IPlayer
    {
        private static Random _random = new Random();

        public IHandSign ChooseSign()
        {
            var randomChoice = _random.Next(3) + 1;

            return HandSignFactory.Create((UserOption)randomChoice);
        }
    }
}
