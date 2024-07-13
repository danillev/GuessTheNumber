using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumberOtus.Interfaces
{
    public interface IRandomNumberGenerator
    {
        int GetRandomGenerate(int minNumber, int maxNumber);
    }
}
