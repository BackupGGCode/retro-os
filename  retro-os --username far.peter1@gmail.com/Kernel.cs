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
            int Hr = (int)Cosmos.Hardware.RTC.Hour;
            int Min = (int)Cosmos.Hardware.RTC.Minute;
            int Sec = (int)Cosmos.Hardware.RTC.Second;
            Console.WriteLine(Hr.ToString() + ":" + Min.ToString() + ":" + Sec.ToString());
            VGA.Mode();
            VGA.Clear(3);
            VGA.Plot(23, 56, 8);

            
            

        }
    }
}
