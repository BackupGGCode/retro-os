using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RETRO.Drivers.RTC
{
    class RTC
    {
        //hour
        public static int Hr()
        {
            return Cosmos.Hardware.RTC.Hour;
        }
        //minute
        public static int Min()
        {
            return Cosmos.Hardware.RTC.Minute;
        }
        //second
        public static int Sec()
        {
            return Cosmos.Hardware.RTC.Second;
        }
        //century
        public static int Cent()
        {
            return Cosmos.Hardware.RTC.Century+1;
        }
        //year
        public static int Yr()
        {
            return Cosmos.Hardware.RTC.Year;
        }
        //month
        public static int Mnth()
        {
            return Cosmos.Hardware.RTC.Month;
        }
        //day of the month
        public static int DOM()
        {
            return Cosmos.Hardware.RTC.DayOfTheMonth;
        }
        //day of the week
        public static int DOY()
        {
            return Cosmos.Hardware.RTC.DayOfTheWeek;
        }

        //print the current time and date
        public static void PrintTime()
        {

            Console.Write("Time: ");
            Console.Write(Hr());
            Console.Write(":");
            Console.Write(Min());
            Console.Write(":");
            Console.WriteLine(Sec());

            Console.Write("Date: ");
            Console.Write(Yr());
            Console.Write("/");
            Console.Write(Mnth());
            Console.Write("/");
            Console.WriteLine(DOM());

            Console.Write("Century: ");
            Console.WriteLine(Cent());



        }

    }
}
