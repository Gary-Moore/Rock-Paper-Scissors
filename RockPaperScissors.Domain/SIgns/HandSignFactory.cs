using System;

namespace RockPaperScissors.Domain.SIgns
{
    public class HandSignFactory
    {
        public static IHandSign Create(UserOption playerSelection)
        {
            switch (playerSelection)
            {
                case UserOption.Rock:
                    return new Rock();
                case UserOption.Paper:
                    return new Paper();
                case UserOption.Scissors:
                    return new Scissors();
                default:
                    throw new ArgumentException("An invalid playerSelection was provided");
                    
            }
        }
    }
}
