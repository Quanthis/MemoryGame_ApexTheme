using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using MemoryGame_ApexTheme;

namespace Tests
{
    [TestClass]
    public class RandomizationTests
    {
        CardPositions[] positions = new CardPositions[2];
        CardPositions[] randomizedPositions = new CardPositions[2];
        

        [TestMethod]
        public void CheckX()
        {
            var positions = InitializeSamplePositions();
            var randomizedPositions = InitializeSamplePositions(true);

            int failedTestsCount = 0;

            for (int i = 0; i < 100; ++i)
            {
                if (positions[0].X.Equals(randomizedPositions[0].X))
                {
                    ++failedTestsCount;
                    if (failedTestsCount > 90)
                    {
                        Assert.Fail();
                    }
                }
                else
                {
                    break;
                }
            }
        }


        [TestMethod]
        public void CheckY()
        {
            var positions = InitializeSamplePositions();
            var randomizedPositions = InitializeSamplePositions(true);
            int failedTestsCount = 0;
            
            for (int i = 0; i < 100; ++i)
            {
                if (positions[0].Y.Equals(randomizedPositions[0].Y))
                {
                    ++failedTestsCount;
                    if(failedTestsCount > 90)
                    {
                        Assert.Fail();
                    }
                }
                else
                {
                    break;
                }
            }
        }

        private CardPositions[] InitializeSamplePositions()
        {
            positions[0] = new CardPositions(1, 5, 0);
            positions[1] = new CardPositions(2, 10, 1);

            return positions;
        }

        private CardPositions[] InitializeSamplePositions(bool randomized)
        {
            randomizedPositions[0] = new CardPositions(1, 5, 0);
            randomizedPositions[1] = new CardPositions(2, 10, 1);

            var randomize = new RandomizePositions(2, randomizedPositions);

            var result = randomize.ReturnNewPositions();

            return result;
        }
    }
}
