using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuessTheNumberOtus.Interfaces;

namespace GuessTheNumberOtus
{
    public class GameLogic : IGameLogic
    {
        private readonly IRandomNumberGenerator _randomNumberGenerator;
        private readonly GameSettings _gameSettings;
        private readonly int _targetNumber;
        private int _attemptsNumber;
        private bool _isGameOver;
        private string _resultMessage;

        public GameLogic(IRandomNumberGenerator randomNumberGenerator, GameSettings gameSettings)
        {
            _randomNumberGenerator = randomNumberGenerator;
            _gameSettings = gameSettings;
            _targetNumber = _randomNumberGenerator.GetRandomGenerate(_gameSettings.MinNumber, _gameSettings.MaxNumber);
            _attemptsNumber = 0;
            _isGameOver = false;
            _resultMessage = string.Empty;
        }

        public void Start(IUserInterface userInterface)
        {
            _isGameOver = false;
            _attemptsNumber = 0;
            userInterface.ShowMessage("Game is Start! Choose your number!");

            while (!this.IsGameOver)
            {
                var guess = GetValidGuess(userInterface);
                this.MakeGuess(guess);
                userInterface.ShowMessage(this.ResultMessage);
            }
        }

        private int GetValidGuess(IUserInterface userInterface)
        {
            int guess = new int();
            bool isValidInput = false;

            while (!isValidInput)
            {
                userInterface.ShowMessage("Enter your number!");
                var input = userInterface.GetInput();
                isValidInput = int.TryParse(input, out guess);

                if (!isValidInput)
                {
                    userInterface.ShowMessage("Invalid input. Please enter a valid integer.");
                }
            }

            return guess;
        }

        public bool MakeGuess(int guess)
        {
            _attemptsNumber++;
            
            if (guess == _targetNumber)
            {
                _isGameOver = true;
                _resultMessage = "Congratulations! You guessed the number.";
                return true;
            }

            if (IsLastAttemption)
            {
                _isGameOver = true;
                _resultMessage = "You've run out of attempts, you've lost! =(";
                return false;

            }

            _resultMessage = guess < _targetNumber ? "The hidden number is bigger." : "The hidden number is smaller.";
            return false;
        }

        public bool IsLastAttemption => _attemptsNumber >= _gameSettings.MaxAttempsNumber;
        public bool IsGameOver => _isGameOver;
        public string ResultMessage => _resultMessage;
    }
}
