using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerrainTools
{
    public class Mountains
    {
        public static float[,] RemoveSmall(float[,] map, float mountainLevel, float minsize)
        {
            float[,] newMap = map;
            for (int y = 0; y < map.GetLength(1); y++)
            {
                for (int x = 0; x < map.GetLength(0); x++)
                {
                    if (map[x, y] >= mountainLevel)
                    {
                        if (GetSize(map, x, y, mountainLevel) <= minsize)
                        {
                            map[x, y] = mountainLevel - 1;
                        }
                    }
                }
            }
            return newMap;
        }

        private static int GetSize(float[,] map, int x, int y, float height)
        {
            int count = 0;
            List<float> foundSquares = new List<float>();

            Queue<int> queueX = new Queue<int>();
            Queue<int> queueY = new Queue<int>();

            foundSquares.Add(float.Parse(x + "," + y));
            queueX.Enqueue(x);
            queueY.Enqueue(y);

            while (queueX.Count != 0 && queueY.Count != 0)
            {
                x = queueX.Dequeue();
                y = queueY.Dequeue();
                try
                {
                    if (map[x, y - 1] >= height && !foundSquares.Contains(float.Parse(x + "," + (y - 1))))
                    {
                        queueX.Enqueue(x);
                        queueY.Enqueue(y - 1);
                        foundSquares.Add(float.Parse(x + "," + (y - 1)));
                        count++;
                    }
                }
                catch (IndexOutOfRangeException) { }

                try
                {
                    if (map[x - 1, y] >= height && !foundSquares.Contains(float.Parse((x - 1) + "," + y)))
                    {
                        queueX.Enqueue(x - 1);
                        queueY.Enqueue(y);
                        foundSquares.Add(float.Parse((x - 1) + "," + y));
                        count++;
                    }
                }
                catch (IndexOutOfRangeException) { }

                try
                {
                    if (map[x, y + 1] >= height && !foundSquares.Contains(float.Parse(x + "," + (y + 1))))
                    {
                        queueX.Enqueue(x);
                        queueY.Enqueue(y + 1);
                        foundSquares.Add(float.Parse(x + "," + (y + 1)));
                        count++;
                    }
                }
                catch (IndexOutOfRangeException) { }

                try
                {
                    if (map[x + 1, y] >= height && !foundSquares.Contains(float.Parse((x + 1) + "," + y )))
                    {
                        queueX.Enqueue(x + 1);
                        queueY.Enqueue(y);
                        foundSquares.Add(float.Parse((x + 1) + "," + y));
                        count++;
                    }
                }
                catch (IndexOutOfRangeException) { }
            }
            return foundSquares.Count;
        }
    }
}
