using System;

namespace Visualizer
{
    class Program
    {
        static void Main(string[] args)
        {
            float[,] map = new float[10, 10];
        }

        private static void Visualize(float[,] map, int width, int height)
        {
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Console.Write(map[x, y]);
                }
                Console.Write(System.Environment.NewLine);
            }
        }
    }
}
