using System;
using System.Collections.Generic;
using System.Text;

namespace Generator
{
    class Generator
    {
        public static float[,] RandomMap(int width, int height, string seed)
        {
            Random rand = new Random(seed.GetHashCode());
            float[,] map = new float[width, height];
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    map[x, y] = (float)rand.NextDouble();
                }
            }
            return map;
        }
    }
}
