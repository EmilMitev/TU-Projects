using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.Logic
{
    class InputValidation
    {
        public string errText { get; private set; }
        public bool isCorrectPlayerInput(string name)
        {
            if (name.Length < 4 || name.Length > 16)
            {
                errText = "Name cannot be less than 4 symbols and more than 16";
                return false;
            }
            return true;
        }
    }
}
