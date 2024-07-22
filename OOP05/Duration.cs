namespace OOP05
{
    internal class Duration
    {
        public double Hours { get; set; }
        public double Minutes { get; set; }
        public double Seconds { get; set; }
        public Duration()
        {
            
        }
        public Duration(int _hours, int _minutes, int _seconds)
        {
            Hours = _hours;
            Minutes = _minutes;
            Seconds = _seconds;
        }
        public Duration(int _durationWithSeconds)
        {
       int totalDurationWithSeconds = _durationWithSeconds;

            int hours = totalDurationWithSeconds / 3600;
            this.Hours = hours;
            totalDurationWithSeconds %= 3600;

            int minutes = totalDurationWithSeconds / 60;
            this.Minutes = minutes;

            int seconds = totalDurationWithSeconds % 60;
            this.Seconds= seconds;




        }
        public override string ToString()
        {
            return $"Hours: {Hours}, Minutes: {Minutes}, Seconds: {Seconds}";
        }
        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static Duration operator +(Duration Left,Duration Right) 
        {
            return new Duration()
            {
                Hours=Left.Hours + Right.Hours,
                Minutes=Left.Minutes + Right.Minutes,
                Seconds=Left.Seconds + Right.Seconds
            };
        }

        public static Duration operator +(Duration Left, int Right)
        {
            return new Duration()
            {
                Hours = Left.Hours,
                Minutes = Left.Minutes,
                Seconds = Left.Seconds +Right
            };
        }

        public static Duration operator +(int Left, Duration Right)
        {
            return new Duration()
            {
                Hours = Right.Hours,
                Minutes = Right.Minutes,
                Seconds = Right.Seconds + Left
            };
        }

        public static Duration operator ++ (Duration D)
        {
            return new Duration()
            {
                Hours = D.Hours,
                Minutes = D.Minutes + 1,
                Seconds = D.Seconds 
            };
        }

        public static Duration operator --(Duration D)
        {
            return new Duration()
            {
                Hours = D.Hours,
                Minutes = D.Minutes - 1,
                Seconds = D.Seconds
            };
        }

        public static Duration operator -(Duration Left, Duration Right)
        {
            return new Duration()
            {
                Hours = Left.Hours - Right.Hours,
                Minutes = Left.Minutes - Right.Minutes,
                Seconds = Left.Seconds - Right.Seconds
            };
        }

        public static bool operator >(Duration Left, Duration Right)
        {
            if (Left.Hours==Right.Hours)
            {
                if (Left.Minutes==Right.Minutes)
                {
                    return Left.Minutes > Right.Minutes;
                }
                else
                    return Left.Minutes > Right.Minutes;

            }
            else
            {
                return Left.Minutes > Right.Minutes;
            }
        }

        public static bool operator <(Duration Left, Duration Right)
        {
            if (Left.Hours == Right.Hours)
            {
                if (Left.Minutes == Right.Minutes)
                {
                    return Left.Minutes < Right.Minutes;
                }
                else
                    return Left.Minutes < Right.Minutes;

            }
            else
            {
                return Left.Minutes < Right.Minutes;
            }
        }

        public static bool operator <=(Duration Left, Duration Right)
        {
            if (Left.Hours == Right.Hours)
            {
                if (Left.Minutes == Right.Minutes)
                {
                    return Left.Minutes <= Right.Minutes;
                }
                else
                    return Left.Minutes <= Right.Minutes;

            }
            else
            {
                return Left.Minutes <= Right.Minutes;
            }
        }

        public static bool operator >=(Duration Left, Duration Right)
        {
            if (Left.Hours == Right.Hours )
            {
                if (Left.Minutes == Right.Minutes)
                {
                    return Left.Minutes >= Right.Minutes;
                }
                else
                    return Left.Minutes >= Right.Minutes;

            }
            else
            {
                return Left.Minutes >= Right.Minutes;
            }
        }

        public static implicit operator bool(Duration duration)
        {
            return false;
        }

        public static implicit operator DateTime(Duration duration)
        {
            return new DateTime();
        }

    }
}
