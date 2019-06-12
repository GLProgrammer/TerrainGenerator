using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerrainTools
{
    public class Rounder
    {
        public static float[,] Round(float[,] map)
        {
            float[,] newMap = map;
            for (int y = 0; y < map.GetLength(1); y++)
            {
                for (int x = 0; x < map.GetLength(0); x++)
                {
                    newMap[x, y] = (float)Math.Round(map[x, y]);
                }
            }

            return newMap;
        }

        public static float[,] RoundDown(float[,] map)
        {
            float[,] newMap = map;
            for (int y = 0; y < map.GetLength(1); y++)
            {
                for (int x = 0; x < map.GetLength(0); x++)
                {
                    newMap[x, y] = (float)Math.Floor(map[x, y]);
                }
            }

            return newMap;
        }
    }
}
