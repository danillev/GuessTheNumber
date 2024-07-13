using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumberOtus.Interfaces
{
    internal interface IUserInterface
    {
        void ShowMessage(string message);
        int GetInput();
    }
}
