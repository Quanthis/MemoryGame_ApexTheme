using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MemoryGame_ApexTheme
{
    public class RandomizePositions : NewPositions
    {
        uint buttonsNumber;
        CardPositions[] cardPositions;

        public RandomizePositions(uint howManyNewPositions, CardPositions[] currentPositions)
        {
            buttonsNumber = howManyNewPositions;
            cardPositions = currentPositions;
        }

        public CardPositions[] ReturnNewPositions()
        {
            CardPositions[] shuffled = new CardPositions[buttonsNumber];
            /*Random r = new Random();

            for (uint i = 0; i < buttonsNumber; i++)
            {
                shuffled[i] = new CardPositions();
                shuffled[i] = r.Next(shuffled[i].GetIndex().Min(), shuffled[i].GetIndex().Max());
            }*/

            return shuffled;
        }
    }
}
