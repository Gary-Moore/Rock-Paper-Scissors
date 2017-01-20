using System;

namespace RockPaperScissors.Domain.SIgns
{
    public class Scissors : IHandSign
    {
        public GameResult Throw(IHandSign opponent)
        {
            var handSignType = opponent.GetType();
            switch (handSignType.Name)
            {
                case "Rock":
                    return GameResult.Lose;

                case "Paper":
                    return GameResult.Win;

                case "Scissors":
                    return GameResult.Draw;

                default: throw new ArgumentException("An invalid handsign value was provided");
            }
        }

        public override string ToString()
        {
            return "Scissors";
        }
    }
}
