using System;
using System.Threading;

namespace MemoryGame_ApexTheme
{
    public class CardPositions
    {
        public int X;
        public int Y;
        private int index = 0;

        public CardPositions(int posX, int posY)
        {
            X = posX;
            Y = posY;
            index = Interlocked.Increment(ref index);
        }

        public CardPositions()
        {

        }

        public int GetIndex()
        {
            return index;
        }
    }
}
