using RockPaperScissors.Domain.SIgns;
using System;
using System.Text;

namespace RockPaperScissors.Domain.Players
{
    public class HumanPlayer : IPlayer
    {
        public IHandSign ChooseSign()
        {
            bool validChoice = false;
            DisplayChoices();
            UserOption option = 0;

            while (!validChoice)
            {
                var selection = Console.ReadKey();
                Console.WriteLine(Environment.NewLine);
                switch (selection.KeyChar)
                {
                    case '1':
                        option = UserOption.Rock;
                        validChoice = true;
                        break;
                    case '2':
                        option = UserOption.Paper;
                        validChoice = true;
                        break;
                    case '3':
                        option = UserOption.Scissors;
                        validChoice = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice please try again.");
                        break;
                }
            }
            
            return HandSignFactory.Create(option);
        }

        private void DisplayChoices()
        {
            Console.Clear();
            var stringBuilder = new StringBuilder(Environment.NewLine);
            stringBuilder.AppendLine("Please choose a hand sign:");
            stringBuilder.AppendLine("1. Rock");
            stringBuilder.AppendLine("2. Paper");
            stringBuilder.AppendLine("3. Scissors");

            Console.WriteLine(stringBuilder.ToString());
        }
    }
}
