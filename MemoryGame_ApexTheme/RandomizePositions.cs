using System;
using System.Linq;
using System.Threading.Tasks;

namespace MemoryGame_ApexTheme
{
    public class RandomizePositions 
    {
        uint buttonsNumber;
        CardPositions[] cardPositions;

        RandomizePositions(uint howManyNewPositions, uint[,] currentPositions)
        {
            buttonsNumber = howManyNewPositions;
        }

        /*public CardPositions[] ReturnNewPositions()
        {
            for(uint i = 0; i < buttonsNumber; i++)
            {
                
            }
        }*/
    }
}
