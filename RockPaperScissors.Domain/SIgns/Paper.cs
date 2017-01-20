using System;

namespace RockPaperScissors.Domain.SIgns
{
    public class Paper : IHandSign
    {
        public GameResult Throw(IHandSign opponent)
        {
            var handSignType = opponent.GetType();
            switch (handSignType.Name)
            {
                case "Rock":
                    return GameResult.Win;

                case "Paper":
                    return GameResult.Draw;

                case "Scissors":
                    return GameResult.Lose;

                default: throw new ArgumentException("An invalid handsign value was provided");
            }
        }

        public override string ToString()
        {
            return "Paper";
        }
    }
}
