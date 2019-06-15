using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerrainTools
{
    public class GoniometricGenerator
    {
        public static float[,] sinWave(int sizeX, int sizeY, float scale = 0.01f, float startTime = 0)
        {
            float[,] map = new float[sizeX, sizeY];
            for (int y = 0; y < sizeY; y++)
            {
                float time = startTime;
                for (int x = 0; x < sizeX; x++)
                {
                    map[x, y] = (float)Math.Sin(time);
                    time += scale;
                }
            }
            return map;
        }
        public static float[,] cosWave(int sizeX, int sizeY, float scale = 0.01f, float startTime = 0)
        {
            float[,] map = new float[sizeX, sizeY];
            for (int y = 0; y < sizeY; y++)
            {
                float time = startTime;
                for (int x = 0; x < sizeX; x++)
                {
                    map[x, y] = (float)Math.Cos(time);
                    time += scale;
                }
            }
            return map;
        }
        public static float[,] tanWave(int sizeX, int sizeY, float scale = 0.01f, float startTime = 0)
        {
            float[,] map = new float[sizeX, sizeY];
            for (int y = 0; y < sizeY; y++)
            {
                float time = startTime;
                for (int x = 0; x < sizeX; x++)
                {
                    map[x, y] = (float)Math.Tan(time);
                    time += scale;
                }
            }
            return map;
        }
        public static float[,] coTanWave(int sizeX, int sizeY, float scale = 0.01f, float startTime = 0)
        {
            float[,] map = new float[sizeX, sizeY];
            for (int y = 0; y < sizeY; y++)
            {
                float time = startTime;
                for (int x = 0; x < sizeX; x++)
                {
                    map[x, y] = (float)(1 / Math.Tan(time));
                    time += scale;
                }
            }
            return map;
        }
    }
}
