using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RETRO.Drivers.VGA
{
    class VGA
    {
        public static Cosmos.Hardware.VGAScreen Vga = new Cosmos.Hardware.VGAScreen();
        public static Cosmos.Hardware.Drivers.PCI.Video.VMWareSVGAII SVga = new Cosmos.Hardware.Drivers.PCI.Video.VMWareSVGAII();

        public static void Plot(int x, int y, int c)
        {
            Vga.SetPixel((uint)x, (uint)y, (uint)c);
        }

        public static void Mode()
        {
            Vga.SetMode320x200x8();

        }

        public static void Clear(int c)
        {
            Vga.Clear(c);
        }
            
    }
}
