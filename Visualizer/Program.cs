﻿using System;
using System.Collections.Generic;
using TerrainTools;

namespace Visualizer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            float[,] map = new float[40, 40];
            float[,] map2 = new float[40, 40];
            map = Generator.PureRandom(40, 40, "asd");
            map2 = Generator.PureRandom(40, 40, "aaa");
            //map = GoniometricGenerator.sinWave(50, 50, 0.5f);
            map = TerrainMath.Multiply(map, 10);
            map = Smooth.SquareSmooth(map);
            map = Mountains.RemoveSmall(map, 6, 9);
            map = Water.RemoveSmall(map, 4, 7);

            map2 = TerrainMath.Multiply(map2, 10);
            map2 = Smooth.SquareSmooth(map);
            map2 = Mountains.RemoveSmall(map, 6, 9);
            map2 = Water.RemoveSmall(map, 4, 7);

            map = TerrainMath.Mix(map, map2);
            //map = TerrainMath.Clamp(map, 0, 9);
            map = Rounder.RoundDown(map);
            //map = Rounder.Round(map);
            VisualizeColor(map);

            Console.ReadLine();
        }

        private static void VisualizePure(float[,] map)
        {
            for (int y = 0; y < map.GetLength(1); y++)
            {
                for (int x = 0; x < map.GetLength(0); x++)
                {
                    Console.Write(map[x, y]);
                }
                Console.Write(System.Environment.NewLine);
            }
        }

        private static void VisualizeColor(float[,] map)
        {
            for (int y = 0; y < map.GetLength(1); y++)
            {
                for (int x = 0; x < map.GetLength(0); x++)
                {
                    switch (map[x, y])
                    {
                        case 0:
                            Console.BackgroundColor = ConsoleColor.DarkBlue;
                            break;
                        case 1:
                            Console.BackgroundColor = ConsoleColor.Blue;
                            break;
                        case 2:
                            Console.BackgroundColor = ConsoleColor.DarkCyan;
                            break;
                        case 3:
                            Console.BackgroundColor = ConsoleColor.Cyan;
                            break;
                        case 4:
                            Console.BackgroundColor = ConsoleColor.DarkGreen;
                            break;
                        case 5:
                            Console.BackgroundColor = ConsoleColor.Green;
                            break;
                        case 6:
                            Console.BackgroundColor = ConsoleColor.DarkYellow;
                            break;
                        case 7:
                            Console.BackgroundColor = ConsoleColor.Gray;
                            break;
                        case 8:
                            Console.BackgroundColor = ConsoleColor.DarkGray;
                            break;
                        case 9:
                            Console.BackgroundColor = ConsoleColor.White;
                            break;
                    }
                    Console.Write(" " + map[x, y] + " ");
                }
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine();
            }
        }
    }
}
