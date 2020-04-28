using System;
using System.Diagnostics;
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
            CardPositions[] shuffledIndexes = new CardPositions[buttonsNumber];
            Random r = new Random();

            int[] indexes = new int[buttonsNumber];

            for(uint i = 0; i < buttonsNumber; ++i)
            {
                indexes[i] = cardPositions[i].GetIndex();                           //getting array of card positions indexes
                //Debug.WriteLine(indexes[i]);
            }

            // Okay, now I think I will just create new objects CardPositions and return it, instead of modyfing existing array

            int[] newIndexes = new int[buttonsNumber];

            for(uint i = 0; i < buttonsNumber ; ++i)
            {
                newIndexes[i] = r.Next(indexes.Min(), indexes.Max());
                //Debug.WriteLine("New index: " + newIndexes[i]);
            }

            for (uint i = 0; i <buttonsNumber; ++i)
            {
                shuffledIndexes[i] = new CardPositions(cardPositions[i].X, cardPositions[i].Y, newIndexes[i]);
            }

            CardPositions[] shuffled = new CardPositions[buttonsNumber];
            for (uint i = 0; i < buttonsNumber; ++i)
            {
                shuffled[i] = new CardPositions(shuffledIndexes[i].X, shuffledIndexes[i].Y, shuffledIndexes[i].GetIndex());
                Debug.WriteLine("Shuffled values: X: " + shuffled[i].X + " Y: " + shuffled[i].Y + " index: " + shuffled[i].GetIndex());
            }

            return shuffled;
        }
    }
}
