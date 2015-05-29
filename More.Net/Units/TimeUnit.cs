using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZMetrology.Units
{
    public struct TimeUnit : IUnit<TimeUnit>
    {
        /// <summary>
        /// 
        /// </summary>
        public static TimeUnit Femtosecond
        {
            get { return femtosecond; }
        }

        /// <summary>
        /// 
        /// </summary>
        public static TimeUnit Picosecond
        {
            get { return picosecond; }
        }

        /// <summary>
        /// 
        /// </summary>
        public static TimeUnit Nanosecond
        {
            get { return nanosecond; }
        }

        /// <summary>
        /// 
        /// </summary>
        public static TimeUnit Millisecond
        {
            get { return millisecond; }
        }

        /// <summary>
        /// 
        /// </summary>
        public static TimeUnit Second
        {
            get { return second; }
        }

        /// <summary>
        /// 
        /// </summary>
        public static TimeUnit Minute
        {
            get { return minute; }
        }

        /// <summary>
        /// 
        /// </summary>
        public static TimeUnit Hour
        {
            get { return hour; }
        }

        /// <summary>
        /// 
        /// </summary>
        public static TimeUnit Week
        {
            get { return week; }
        }

        /// <summary>
        /// 
        /// </summary>
        public static TimeUnit Year
        {
            get { return year; }
        }

        /// <summary>
        /// 
        /// </summary>
        public static TimeUnit Decade
        {
            get { return decade; }
        }

        /// <summary>
        /// 
        /// </summary>
        public static TimeUnit Century
        {
            get { return century; }
        }

        /// <summary>
        /// 
        /// </summary>
        public static TimeUnit Millenium
        {
            get { return millenium; }
        }

        public static IEnumerable<TimeUnit> Enumerate()
        {
            yield return femtosecond;
            yield return picosecond;
            yield return nanosecond;
            yield return microsecond;
            yield return millisecond;
            yield return second;
            yield return minute;
            yield return hour;
            yield return day;
            yield return week;
            yield return year;
            yield return decade;
            yield return century;
            yield return millenium;
        }

        static TimeUnit()
        {
            femtosecond = new TimeUnit("Femtosecond", 1.0e-15);
            picosecond = new TimeUnit("Picosecond", 1.0e-12);
            nanosecond = new TimeUnit("Nanosecond", 1.0e-9);
            microsecond = new TimeUnit("Microsecond", 1.0e-6);
            millisecond = new TimeUnit("Millisecond", 1.0e-3);
            second = new TimeUnit("Second", 1.0e+0);
            minute = new TimeUnit("Minute", 6.0e+1);
            hour = new TimeUnit("Hour", 3.6e+3);
            day = new TimeUnit("Day", 8.64e+4);
            week = new TimeUnit("Week", 6.048e+5);
            year = new TimeUnit("Year", 3.15569e7);
            decade = new TimeUnit("Decade", 3.15569e8);
            century = new TimeUnit("Century", 3.15569e9);
            millenium = new TimeUnit("Millenium", 3.15569e10);
        }

        public TimeUnit(String name, Double conversionFactor)
        {
            this.conversionFactor = conversionFactor;
            this.name = name;
        }
        private readonly Double conversionFactor;
        private readonly String name;

        private static readonly TimeUnit femtosecond;
        private static readonly TimeUnit picosecond;
        private static readonly TimeUnit nanosecond;
        private static readonly TimeUnit microsecond;
        private static readonly TimeUnit millisecond;
        private static readonly TimeUnit second;
        private static readonly TimeUnit minute;
        private static readonly TimeUnit hour;
        private static readonly TimeUnit day;
        private static readonly TimeUnit week;
        private static readonly TimeUnit year;
        private static readonly TimeUnit decade;
        private static readonly TimeUnit century;
        private static readonly TimeUnit millenium;

        public bool Equals(TimeUnit other)
        {
            throw new NotImplementedException();
        }

        public double ConversionFactor
        {
            get { return conversionFactor; }
        }

        public string ToString(string format, IFormatProvider formatProvider)
        {
            throw new NotImplementedException();
        }
    }
}
