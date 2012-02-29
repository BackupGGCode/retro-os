using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RETRO.Drivers.VGA
{
    class VGA
    {
        public static Cosmos.Hardware.VGAScreen Vga = new Cosmos.Hardware.VGAScreen();
        public static Cosmos.Hardware.Drivers.PCI.Video.VMWareSVGAII SVGA = new Cosmos.Hardware.Drivers.PCI.Video.VMWareSVGAII();

        public static void Plot(int x, int y, int c)
        {
            //Vga.SetPixel((uint)x, (uint)y, (uint)c);
            SVGA.SetPixel((ushort)x, (ushort)y, (uint)c);
        }

        public static void Mode()
        {
            //Vga.SetMode320x200x8();
            SVGA.SetMode(1024, 768, 16);
        }

        public static void Clear(int c)
        {
            //Vga.Clear(c);
            SVGA.Clear((uint)c);
        }
            
    }
}
