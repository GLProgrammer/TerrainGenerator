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
        public static float[,] Multiply(float[,] map, float[,] map2)
        {
            float[,] newMap = map;
            for (int y = 0; y < map.GetLength(1); y++)
            {
                for (int x = 0; x < map.GetLength(0); x++)
                {
                    newMap[x, y] = map[x, y] * map2[x, y];
                }
            }
            return newMap;
        }
        public static float[,] Add(float[,] map, float number)
        {
            float[,] newMap = map;
            for (int y = 0; y < map.GetLength(1); y++)
            {
                for (int x = 0; x < map.GetLength(0); x++)
                {
                    newMap[x, y] += number;
                }
            }
            return newMap;
        }
        public static float[,] Add(float[,] map, float[,] map2)
        {
            float[,] newMap = map;
            for (int y = 0; y < map.GetLength(1); y++)
            {
                for (int x = 0; x < map.GetLength(0); x++)
                {
                    newMap[x, y] = map[x, y] + map2[x, y];
                }
            }
            return newMap;
        }
        public static float[,] Divide(float[,] map, float number)
        {
            float[,] newMap = map;
            for (int y = 0; y < map.GetLength(1); y++)
            {
                for (int x = 0; x < map.GetLength(0); x++)
                {
                    newMap[x, y] = map[x, y] * number;
                }
            }
            return newMap;
        }
        public static float[,] Divide(float[,] map, float[,] map2)
        {
            float[,] newMap = map;
            for (int y = 0; y < map.GetLength(1); y++)
            {
                for (int x = 0; x < map.GetLength(0); x++)
                {
                    newMap[x, y] = map[x, y] / map2[x, y];
                }
            }
            return newMap;
        }
        public static float[,] Substract(float[,] map, float number)
        {
            float[,] newMap = map;
            for (int y = 0; y < map.GetLength(1); y++)
            {
                for (int x = 0; x < map.GetLength(0); x++)
                {
                    newMap[x, y] -= number;
                }
            }
            return newMap;
        }
        public static float[,] Substract(float[,] map, float[,] map2)
        {
            float[,] newMap = map;
            for (int y = 0; y < map.GetLength(1); y++)
            {
                for (int x = 0; x < map.GetLength(0); x++)
                {
                    newMap[x, y] = map[x, y] - map2[x, y];
                }
            }
            return newMap;
        }
        public static float[,] Clamp(float[,] map, float min, float max)
        {
            float[,] newMap = map;
            float arrayMin = float.MinValue;
            float arrayMax = float.MaxValue;
            for (int y = 0; y < map.GetLength(1); y++)
            {
                for (int x = 0; x < map.GetLength(0); x++)
                {
                    if (newMap[x, y] < min)
                    {
                        arrayMin = newMap[x, y];
                    }

                    if (newMap[x, y] > max)
                    {
                        arrayMax = newMap[x, y];
                    }
                }
            }

            float m = (max - min) / (arrayMax - arrayMin);
            float c = min - arrayMin * m;
            for (int y = 0; y < map.GetLength(1); y++)
            {
                for (int x = 0; x < map.GetLength(0); x++)
                {
                    newMap[x, y] = m * map[x, y] + c;
                }
            }
            return newMap;
        }
        
        /// <summary>
        /// Set positions to override
        /// </summary>
        /// <param name="map">Default map</param>
        /// <param name="positions">Set to negative if you dont want to include it</param>
        /// <returns>New map</returns>
        public static float[,] Over(float[,] map, float[,] positions)
        {
            float[,] newMap = map;

            for (int x = 0; x < positions.GetLength(1); x++)
            {
                for (int y = 0; y < positions.GetLength(0); y++)
                {
                    if (positions[x, y] >= 0)
                    {
                        newMap[x, y] = positions[x, y];
                    }
                }
            }


            return newMap;
        }
    }
}
