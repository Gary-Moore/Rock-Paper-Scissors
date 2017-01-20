using System;
using RockPaperScissors.Domain;

namespace RockPaperScissors.App
{
    public class GameRenderer
    {   
        private bool _gameRunning;
        private Game _game;
        public void Start()
        {
            _gameRunning = true;
            while (_gameRunning)
            {
                ShowMenu();
                ChooseGameOption();

                if (_gameRunning)
                {
                    Console.Clear();
                    var result = _game.Play();
                    DisplayResult(result);
                }
            }
        }

        private void DisplayResult(GameResult result)
        {
            string outputText = string.Empty;
            switch (result)
            {
                case GameResult.Lose:
                    outputText = "Player 2 wins";
                    break;
                case GameResult.Win:
                    outputText = "Player 1 wins";
                    break;
                case GameResult.Draw:
                    outputText = "It's a Tie!";
                    break;
            }

            Console.WriteLine(Environment.NewLine);
            OutputSeperatorLine();
            Console.WriteLine(outputText);
            OutputSeperatorLine();
            Console.WriteLine(Environment.NewLine);
            
        }
        
        private void ShowMenu()
        {
            OutputSeperatorLine();
            Console.WriteLine("Welcome to Rock, Paper, Scissors");
            OutputSeperatorLine();
            Console.WriteLine("Please select a game type:");
            Console.WriteLine("1. Player vs Computer");
            Console.WriteLine("2. Computer vs Computer");
            Console.WriteLine("q: Exit");
        }

        private void ChooseGameOption()
        {
            bool validGameTypeChosen = false;

            while (!validGameTypeChosen)
            {
                var selection = Console.ReadKey();
                switch (selection.KeyChar)
                {
                    case '1':
                        _game = Game.Create( GameType.PlayerVsComputer);
                        validGameTypeChosen = true;
                        break;
                    case '2':
                        _game = Game.Create(GameType.ComputerVsComputer);
                        validGameTypeChosen = true;
                        break;
                    case 'q':
                    case 'Q':
                        validGameTypeChosen = true;
                        _gameRunning = false;
                        break;
                    default:
                        Console.WriteLine(Environment.NewLine);
                        Console.WriteLine("Invalid choice please try again.");
                        break;
                }
            }
        }
        
        private static void OutputSeperatorLine()
        {
            Console.WriteLine("========================================");
        }
    }
}
