using System;

namespace RockPaperScissors.Domain.SIgns
{
    public class Rock : IHandSign
    {
        public GameResult Throw(IHandSign opponent)
        {
            var handSignType = opponent.GetType();
            switch (handSignType.Name)
            {
                case "Rock":
                    return GameResult.Draw;

                case "Paper":
                    return GameResult.Lose;

                case "Scissors":
                    return GameResult.Win;

                default: throw new ArgumentException("An invalid handsign value was provided");
            }
        }

        public override string ToString()
        {
            return "Rock";
        }
    }
}
