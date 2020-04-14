using System;
using System.Linq;
using System.Threading.Tasks;

namespace MemoryGame_ApexTheme
{
    public class RandomizePositions : NewPositions
    {
        uint buttonsNumber;
        uint[,] possiblePositions;

        RandomizePositions(uint howManyNewPositions, uint[,] currentPositions)
        {
            buttonsNumber = howManyNewPositions;
            possiblePositions = currentPositions;
        }

        public uint[,] ReturnNewPositions()
        {
            uint[,] possblePositions = new uint[buttonsNumber, 2];
            return possiblePositions;
        }
    }
}
