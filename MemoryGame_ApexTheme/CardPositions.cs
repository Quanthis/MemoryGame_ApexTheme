using System;
using System.Threading;

namespace MemoryGame_ApexTheme
{
    public class CardPositions
    {
        public int X;
        public int Y;
        private int index;

        private static int globalIndex = 0;

        public CardPositions(int posX, int posY)
        {
            X = posX;
            Y = posY;

            index = Interlocked.Increment(ref globalIndex);
        }

        public CardPositions(int posX, int posY, int newIndex)
        {
            X = posX;
            Y = posY;
            index = newIndex;
            Interlocked.Increment(ref globalIndex);
        }

        public CardPositions()
        {
            index = Interlocked.Increment(ref globalIndex);
        }


        public int GetIndex()
        {
            return index;
        }

        public void SetNewPositions(int posX, int posY)
        {
            X = posX;
            Y = posY;
        }
    }
}
