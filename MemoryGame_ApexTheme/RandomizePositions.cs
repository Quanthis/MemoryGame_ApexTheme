using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MemoryGame_ApexTheme
{
    public class RandomizePositions : NewPositions, IDisposable
    {
        private uint buttonsNumber;
        private CardPositions[] cardPositions;
        private CardPositions[] finalPosition;
        private bool disposed = false;

        public RandomizePositions(uint howManyNewPositions, ref CardPositions[] currentPositions)
        {
            buttonsNumber = howManyNewPositions;
            cardPositions = currentPositions;
            finalPosition = new CardPositions[buttonsNumber];
        }

        public async Task<CardPositions[]> ReturnNewPositions()
        {
            return await Task.Run(async () =>
            {
                await GetNewPositions();
                return finalPosition;
            });
        }

        private async Task GetNewPositions()
        {
            await Task.Run(() =>
            {
                Random r = new Random();

                int[] indexes = new int[buttonsNumber];

                for (uint i = 0; i < buttonsNumber; ++i)
                {
                    indexes[i] = cardPositions[i].GetIndex();                           //getting array of card positions indexes
                }


                int[] newIndexes = new int[buttonsNumber];
                List<int> list = indexes.ToList();
                int iter = 0;

                foreach (int i in UniqueRandom(list.Min(), list.Max(), list))
                {
                    newIndexes[iter] = i;
                    ++iter;
                }

                CardPositions[] shuffled = new CardPositions[buttonsNumber];
                for (uint i = 0; i < buttonsNumber; ++i)
                {
                    shuffled[i] = new CardPositions(cardPositions[i].X, cardPositions[i].Y, newIndexes[i]);
                }

                int succesIteration = 0;
                foreach (var position in cardPositions)
                {
                    foreach (var pos in shuffled)
                    {
                        if (position.GetIndex() == pos.GetIndex())
                        {
                            finalPosition[succesIteration] = pos;
                            ++succesIteration;
                        }
                    }
                }
            });
        }

        private IEnumerable<int> UniqueRandom(int min, int max, List<int> list)
        {
            Random rnd = new Random();
            while (list.Count > 0)
            {
                int index = rnd.Next(list.Count - 1);
                yield return list[index];
                list.RemoveAt(index);
            }
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
                    for(int i = 0; i < buttonsNumber; ++i)
                    {
                        cardPositions[i].Dispose();
                        finalPosition[i].Dispose();
                    }
                }

                disposed = true;
            }
        }

        ~RandomizePositions()
        {
            Dispose(false);
        }

        #endregion
    }
}