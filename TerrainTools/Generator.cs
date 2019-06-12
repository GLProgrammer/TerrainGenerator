using System;
using System.Collections.Generic;
using System.Text;

namespace TerrainTools
{
    public class Generator
    {
        public static float[,] PureRandom(int width, int height, string seed)
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

        public static float[,] PureRandom(int width, int height)
        {
            Random rand = new Random();
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