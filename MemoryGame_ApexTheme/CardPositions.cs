using System;
using System.Threading;

namespace MemoryGame_ApexTheme
{
    public class CardPositions
    {
        public int X;
        public int Y;
        private int index;

        private static int globalIndex = -1;

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

        public CardPositions(CardPositions cardPositions)
        {
            X = cardPositions.X;
            Y = cardPositions.Y;
            index = cardPositions.GetIndex();
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

        public override string ToString()
        {
            string result = X + "" + Y + "" + index;
            return result;
        }
    }
}
