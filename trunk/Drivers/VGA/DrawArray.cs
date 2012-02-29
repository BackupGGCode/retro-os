using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RETRO.Drivers.VGA
{
    class DrawArray
    {
        public static void Dr(int X, int Y, int Xs, int Ys, int[] Array)
        {
            Cosmos.Hardware.VGAScreen VGA = new Cosmos.Hardware.VGAScreen();
            for(int x = 0; x < Xs; x++)
            {
                for (int y = 0; y < Ys; y++)
                {
                    VGA.SetPixel((uint)(x + X), (uint)(y + Y), (uint)(Array[x * y]));
                }
            }
        }
    }
}
