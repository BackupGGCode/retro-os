using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;
using RETRO.Drivers.VGA;

namespace RETRO
{
    public class Kernel : Sys.Kernel
    {
        protected override void BeforeRun()
        {
            Console.WriteLine("Cosmos booted successfully. Type a line of text to get it echoed back.");
        }

        protected override void Run()
        {
            Console.Write("Input: ");
            var input = Console.ReadLine();
            Console.Write("Text typed: ");
            Console.WriteLine(input);
            RETRO.Drivers.RTC.RTC.PrintTime();
            //VGA.Mode();
            //VGA.Clear(3);
            //VGA.Plot(23, 56, 8);
            Cosmos.Hardware.Drivers.PCI.Video.VMWareSVGAII SVGA = new Cosmos.Hardware.Drivers.PCI.Video.VMWareSVGAII();
            SVGA.SetMode(1024, 768, 8);
            for (int x = 0; x < 256; x++)
            {
                ushort y = (ushort)(x * 32);
                SVGA.Fill(y,1,32,32,(uint)x);
            }

            
            

        }
    }
}
