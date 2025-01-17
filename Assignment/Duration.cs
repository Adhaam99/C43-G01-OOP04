using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Duration
    {

        #region Attributes

        private int seconds;

        private int minutes;

        private int hours;

        #endregion

        #region Properties

        public int Seconds { get => seconds; set => seconds = value; }
        public int Minutes { get => minutes; set => minutes = value; }
        public int Hours { get => hours; set => hours = value; }

        #endregion

        #region Constructors

        public Duration( int hours , int minutes, int seconds )
        {
            Seconds = seconds;
            Minutes = minutes;
            Hours = hours;
        }

        public Duration(int seconds) 
        {
        
            Seconds = seconds;

            if ( seconds >= 60 )
            {
                minutes = seconds / 60;

                if ( minutes >= 60 )
                {
                    hours = minutes / 60;
                }
            }
        }

        #endregion

        #region Methods

        public override string ToString()
        {
            if ( minutes == 0 )
            {
                return $"Seconds : {seconds}";
            }
            else
            {

                if (hours > 0)
                    return $"Hours : {Hours} ,Minutes : {minutes % 60} ,Seconds : {seconds % 60}";
                else
                    return $"Minutes : {minutes} ,Seconds : {seconds % 60}";
            }
        }

        #endregion

        #region Operators Override

        // D3=D1+D2

        public static Duration operator +( Duration a, Duration b )
        {
            return new Duration((a?.Hours ?? 0) + (b?.Hours ?? 0), (a?.Minutes ?? 0) + (b?.Minutes ?? 0), (a?.Seconds ?? 0) + (b?.Seconds ?? 0));  
        }

        // D3 = D1 + 7800

        public static Duration operator +(Duration a, int seconds)
        {
            Duration b = new Duration(seconds);

            return a + b;
        }

        // D3=666+D3
        public static Duration operator +(int seconds, Duration a )
        {
            Duration b = new Duration(seconds);

            return a + b;
        }

        //  D3= ++D1 (Increase One Minute)

        public static Duration operator ++(Duration a)
        {
            return new Duration(a?.Hours ?? 0, (a?.Minutes ?? 0 ) + 1, a?.Seconds ?? 0);
        }

        // D3= --D1 (Increase One Minute)
        public static Duration operator --(Duration a)
        {
            return new Duration(a?.Hours ?? 0, (a?.Minutes ?? 0) - 1, a?.Seconds ?? 0);
        }

        // D1= D1 - D2
        public static Duration operator -(Duration a, Duration b)
        {
            return new Duration((a?.Hours ?? 0) - (b?.Hours ?? 0), (a?.Minutes ?? 0) - (b?.Minutes ?? 0), (a?.Seconds ?? 0) - (b?.Seconds ?? 0));
        }

        // f (D1>D2)

        public static bool operator > (Duration a, Duration b)
        {

            if (a.Hours == b.Hours)
            {
                if(a.Minutes == b.Minutes)
                { 
                
                    return a.seconds > b.seconds;

                }
                else
                {
                    return a.minutes > b.minutes;
                }
            }
            else
            {
                return a.Hours > b.Hours;
            }

        }

        public static bool operator <(Duration a, Duration b)
        {
            if (a.Hours == b.Hours)
            {
                if (a.Minutes == b.Minutes)
                {

                    return a.seconds < b.seconds;

                }
                else
                {
                    return a.minutes < b.minutes;
                }
            }
            else
            {
                return a.Hours < b.Hours;
            }

        }

        // if(D1 >= D2)

        public static bool operator >=(Duration a, Duration b)
        {

            if (a.Hours == b.Hours)
            {
                if (a.Minutes == b.Minutes)
                {

                    return a.seconds >= b.seconds;

                }
                else
                {
                    return a.minutes >= b.minutes;
                }
            }
            else
            {
                return a.Hours >= b.Hours;
            }

        }

        public static bool operator <=(Duration a, Duration b)
        {

            if (a.Hours == b.Hours)
            {
                if (a.Minutes == b.Minutes)
                {

                    return a.seconds <= b.seconds;

                }
                else
                {
                    return a.minutes <= b.minutes;
                }
            }
            else
            {
                return a.Hours <= b.Hours;
            }

        }


        // DateTime Obj = (DateTime) D1

        public static explicit operator DateTime(Duration a)
        {
            DateTime b = new DateTime(2025, 1, 15, ((a?.Hours ?? 0) % 24 ), ((a?.Minutes ?? 0) % 60), ((a?.Seconds ?? 0) % 60 ));
            return b;
        }

        #endregion


    }
}
