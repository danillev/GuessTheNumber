using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumberOtus.Interfaces
{
    public interface IGameLogic
    {
        void Start();
        bool MakeGuess(int guess);
        bool IsGameOver {  get; }
        string ResultMessage { get; }
        bool IsLastAttemption { get; }

    }
}
