using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerrainTools
{
    public class Water
    {
        public static float[,] Reduce(float[,] map, float waterLevel, float add)
        {
            float[,] newMap = map;
            for (int y = 0; y < map.GetLength(1) - 1; y++)
            {
                for (int x = 0; x < map.GetLength(0) - 1; x++)
                {
                    if (map[x, y] <= waterLevel)
                    {
                        newMap[x, y] = (map[x, y] + map[x + 1, y] + map[x, y + 1]) / 3;
                        newMap[x, y] += add;
                    }
                }
            }
            return newMap;
        }

        public static float[,] Remove(float[,] map, float waterLevel, float newLevel)
        {
            float[,] newMap = map;
            for (int y = 0; y < map.GetLength(1); y++)
            {
                for (int x = 0; x < map.GetLength(0); x++)
                {
                    if (map[x, y] <= waterLevel + 1)
                    {
                        newMap[x, y] = newLevel;
                    }
                }
            }
            return newMap;
        }
    }
}
