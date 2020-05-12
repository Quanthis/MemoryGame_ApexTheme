using System;
using System.Threading;

namespace MemoryGame_ApexTheme
{
    public class CardPositions : IDisposable
    {
        public int X;
        public int Y;
        private int index;
        private bool disposed = false;

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

        #region Cleaning

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    
                }

                disposed = true;
            }
        }

        ~CardPositions()
        {
            Dispose(false);
        }

        #endregion
    }
}
