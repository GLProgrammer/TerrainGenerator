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
                for (int x = 0; x < map.GetLength(0); x++)
                {
                    float value = 0;
                    float divider = 0;
                    try
                    {
                        value += map[x - 1, y];
                        divider++;
                    }
                    catch (IndexOutOfRangeException e) { }
                    try
                    {
                        value += map[x, y];
                        divider++;
                    }
                    catch (IndexOutOfRangeException e) { }
                    try
                    {
                        value += map[x + 1, y];
                        divider++;
                    }
                    catch (IndexOutOfRangeException e) { }
                    value = value / divider;
                    newMap[x, y] = value;
                }
            }
            return newMap;
        }
        public static float[,] VerticalSmooth(float[,] map)
        {
            float[,] newMap = map;
            for (int y = 0; y < map.GetLength(1); y++)
            {
                for (int x = 0; x < map.GetLength(0); x++)
                {
                    float value = 0;
                    float divider = 0;
                    try
                    {
                        value += map[x, y - 1];
                        divider++;
                    }
                    catch (IndexOutOfRangeException e) { }
                    try
                    {
                        value += map[x, y];
                        divider++;
                    }
                    catch (IndexOutOfRangeException e) { }
                    try
                    {
                        value += map[x, y + 1];
                        divider++;
                    }
                    catch (IndexOutOfRangeException e) { }
                    value = value / divider;
                    newMap[x, y] = value;
                }
            }
            return newMap;
        }
        public static float[,] SquareSmooth(float[,] map)
        {
            float[,] newMap = map;
            for (int y = 0; y < map.GetLength(1); y++)
            {
                for (int x = 0; x < map.GetLength(0); x++)
                {
                    float value = 0;
                    float divider = 0;
                    try
                    {
                        value += map[x - 1, y - 1];
                        divider++;
                    }
                    catch (IndexOutOfRangeException e) { }

                    try
                    {
                        value += map[x, y - 1];
                        divider++;
                    }
                    catch (IndexOutOfRangeException e) { }

                    try
                    {
                        value += map[x + 1, y - 1];
                        divider++;
                    }
                    catch (IndexOutOfRangeException e) { }

                    try
                    {
                        value += map[x - 1, y];
                        divider++;
                    }
                    catch (IndexOutOfRangeException e) { }

                    try
                    {
                        value += map[x, y];
                        divider++;
                    }
                    catch (IndexOutOfRangeException e) { }

                    try
                    {
                        value += map[x + 1, y];
                        divider++;
                    }
                    catch (IndexOutOfRangeException e) { }

                    try
                    {
                        value += map[x - 1, y + 1];
                        divider++;
                    }
                    catch (IndexOutOfRangeException e) { }

                    try
                    {
                        value += map[x, y + 1];
                        divider++;
                    }
                    catch (IndexOutOfRangeException e) { }

                    try
                    {
                        value += map[x + 1, y + 1];
                        divider++;
                    }
                    catch (IndexOutOfRangeException e) { }

                    value = value / divider;
                    newMap[x, y] = value;
                }
            }
            return newMap;
        }
    }
}
