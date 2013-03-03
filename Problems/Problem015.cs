using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Problems
{
    [TestFixture]
    public class Problem015
    {
        private const int gridSize = 21;

        [Test]
        public void Test()
        {
            var grid = new ulong[gridSize, gridSize];
            grid[0, 0] = 1;

            // You can only move right and down.

            // Dynamic programming. The number of routes is equal to the sum of the node to the left and top nodes from the current node.

            // Go down first. Then across
            for (int x = 0; x < gridSize; x++)
            {
                for (int y = 0; y < gridSize; y++)
                {
                    ulong sum = 0;
                    if (x - 1 >= 0) // Left
                    {
                        sum += grid[x - 1, y];
                    }

                    if (y - 1 >= 0) // Top
                    {
                        sum += grid[x, y - 1];
                    }

                    if (x == 0 && y == 0)
                    {
                        sum = 1;
                    }

                    grid[x, y] = sum;
                }
            }

            for (int x = 0; x < gridSize; x++)
            {
                Debug.Write("|");
                for (int y = 0; y < gridSize; y++)
                {
                    Debug.Write(grid[x, y]);
                    Debug.Write("|");
                }

                Debug.WriteLine("");
            }

            Assert.Inconclusive(grid[gridSize - 1, gridSize-1].ToString());
        }
    }
}

