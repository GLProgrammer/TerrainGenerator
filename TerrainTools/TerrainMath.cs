using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerrainTools
{
    public class TerrainMath
    {
        public static float[,] Multiply(float[,] map, float number)
        {
            float[,] newMap = map;
            for (int y = 0; y < map.GetLength(1); y++)
            {
                for (int x = 0; x < map.GetLength(0); x++)
                {
                    newMap[x, y] *= number;
                }
            }
            return newMap;
        }
    }
}
