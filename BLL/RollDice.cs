using System;
using System.Collections.Generic;
using System.Text;


namespace BLL
{
    class RollDice
    {
        public int Roll(int Dice)
        {

            Random Rnd = new Random();
            int Result;

            Result = Rnd.Next(1, Dice + 1);

            return Result;
        }
    }
}
