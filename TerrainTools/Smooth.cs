using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerrainTools
{
    public class Smooth
    {
        public static float[,] HorizontalSmooth(float[,] map)
        {
            float[,] newMap = map;
            for (int y = 0; y < map.GetLength(1); y++)
            {
                for (int x = 0; x < map.GetLength(0) - 1; x++)
                {
                    newMap[x, y] = (map[x, y] + map[x + 1, y]) / 2;
                }
            }
            return newMap;
        }

        public static float[,] VerticalSmooth(float[,] map)
        {
            float[,] newMap = map;
            for (int y = 0; y < map.GetLength(1) -1; y++)
            {
                for (int x = 0; x < map.GetLength(0); x++)
                {
                    newMap[x, y] = (map[x, y] + map[x, y + 1]) / 2;
                }
            }
            return newMap;
        }
    }
}
