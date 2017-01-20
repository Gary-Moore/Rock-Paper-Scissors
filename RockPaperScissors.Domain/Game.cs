using RockPaperScissors.Domain.Players;
using System;

namespace RockPaperScissors.Domain
{
    public class Game
    {
        private IPlayer _player1;
        private IPlayer _player2;

        public Game(IPlayer player1, IPlayer player2)
        {
            _player1 = player1;
            _player2 = player2;
        }
        
        public GameResult Play()
        {
            var player1Sign = _player1.ChooseSign();
            Console.WriteLine("Player 1 chooses : " + player1Sign.ToString());

            var player2Sign = _player2.ChooseSign();
            Console.WriteLine("Player 2 chooses : " + player2Sign.ToString());

            return player1Sign.Throw(player2Sign);
        }
       
        public static Game Create(GameType gameType)
        {
            IPlayer player1;
            IPlayer player2;    
            switch (gameType)
            {
                case GameType.PlayerVsComputer:
                    player1 = new HumanPlayer();
                    player2 = new ComputerPlayer();
                    break;
                case GameType.ComputerVsComputer:
                    player1 = new ComputerPlayer();
                    player2 = new ComputerPlayer();
                    break;
                default: throw new ArgumentException("An invalid game type option was provided");
            }

            return new Game(player1, player2);
        }
    }
}
