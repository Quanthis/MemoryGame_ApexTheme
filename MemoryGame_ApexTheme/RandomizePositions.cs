using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MemoryGame_ApexTheme
{
    public class RandomizePositions : NewPositions
    {
        private uint buttonsNumber;
        private CardPositions[] cardPositions;
        private CardPositions[] finalPosition;

        public RandomizePositions(uint howManyNewPositions, CardPositions[] currentPositions)
        {
            buttonsNumber = howManyNewPositions;
            cardPositions = currentPositions;
            finalPosition = new CardPositions[buttonsNumber];
        }

        public CardPositions[] ReturnNewPositions()
        {
            GetNewPositions();
            return finalPosition;
        }

        private void GetNewPositions()
        {
            Random r = new Random();

            int[] indexes = new int[buttonsNumber];

            for(uint i = 0; i < buttonsNumber; ++i)
            {
                indexes[i] = cardPositions[i].GetIndex();                           //getting array of card positions indexes
            }

            // Okay, now I think I will just create new objects CardPositions and return it, instead of modyfing existing array

            int[] newIndexes = new int[buttonsNumber];

            for(uint i = 0; i < buttonsNumber ; ++i)
            {
                newIndexes[i] = r.Next(indexes.Min(), indexes.Max());
            }

            CardPositions[] shuffled = new CardPositions[buttonsNumber];
            for (uint i = 0; i < buttonsNumber; ++i)
            {
                shuffled[i] = new CardPositions(cardPositions[i].X, cardPositions[i].Y, newIndexes[i]);
            }

            #region NotWorkingLoop
            /*foreach (var position in cardPositions)
            {
                int i = 0;
                int outerIteration = 0;

                Debug.WriteLine(position.GetIndex());

                while (cardPositions[outerIteration].GetIndex() != shuffled[outerIteration].GetIndex())
                {
                    Debug.WriteLine("Checked item: " + cardPositions[i].GetIndex() + " 2nd checked: " + shuffled[i].GetIndex());


                    if (cardPositions[i].GetIndex() == shuffled[i].GetIndex())
                    {
                        Debug.WriteLine("Changing  position: " + cardPositions[i].GetIndex() + " to: " + shuffled[i].GetIndex());

                        finalPosition[i] = shuffled[i];

                        Debug.WriteLine("Changed  position: " + finalPosition[i].GetIndex() + " to: " + shuffled[i].GetIndex());
                        break;
                    }

                    
                    if(i == cardPositions.Length - 1)
                    {
                        Debug.WriteLine("Not found.");

                        finalPosition[i] = cardPositions[i];

                        break;
                    }

                    ++i;
                }

                ++outerIteration;
            }

            Debug.WriteLine(finalPosition[0] + " sample ");
            */

            #endregion

            int succesIteration = 0;
            foreach (var position in cardPositions)
            {
                foreach(var pos in shuffled)
                {
                    if(position.GetIndex() == pos.GetIndex())
                    {
                        finalPosition[succesIteration] = pos;
                        Debug.WriteLine("Succeded iteration: " + finalPosition[succesIteration]);
                        ++succesIteration;
                    }
                }
            }
        }
    }
}