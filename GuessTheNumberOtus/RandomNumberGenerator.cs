using GuessTheNumberOtus.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumberOtus
{
    public class RandomNumberGenerator : IRandomNumberGenerator
    {
        private static readonly Random _randomNumber = new Random();
        public int GetRandomGenerate(int minNumber, int maxNumber)
        {
            return _randomNumber.Next(minNumber, maxNumber + 1);
        }
    }
}
