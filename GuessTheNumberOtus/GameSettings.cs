using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumberOtus
{
    public record class GameSettings
    {
        public int MinNumber {  get; init; }
        public int MaxNumber { get; init; }
        public int MaxAttempsNumber { get; init; }

        public GameSettings(int minNumber, int maxNumber, int maxAttempsNumber)
        {
            MinNumber = minNumber;
            MaxNumber = maxNumber;
            MaxAttempsNumber = maxAttempsNumber;
        }
    }    
}
