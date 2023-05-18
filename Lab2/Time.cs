using System;

namespace Lab2
{
    public class Time
    {
        public int Hour;
        public int Minute;
        public int Second;
        public Time() //конструктор класса по умолчанию
        {
            Hour = 0;
            Minute = 0;
            Second = 0;
        }
        public Time(int Hour, int Minute, int Second)
        {
            if (Hour < 0 || Hour >= 24)
            {
                throw new Exception("Incorrect value of hours!");
            }
            this.Hour = Hour;
            if (Minute < 0 || Minute >= 60)
            {
                throw new Exception("Incorrect value of minutes!");
            }
            this.Minute = Minute;
            if (Second < 0 || Second >= 60)
            {
                throw new Exception("Incorrect value of seconds!");
            }
            this.Second = Second;
        }

        public void setHour(int h)
        {
            if (h < 0 || h >= 24)
            {
                throw new Exception("Incorrect value of hours!");
            }
            Hour = h;
        }

        public void setMinute(int m)
        {
            if (m < 0 || m >= 60)
            {
                throw new Exception("Incorrect value of minutes!");
            }
            Minute = m;
        }

        public void setSecond(int s)
        {
            if (s < 0 || s >= 60)
            {
                throw new Exception("Incorrect value of seconds!");
            }
            Second = s;
        }

        public override String ToString()
        {
            return "Time: " + Hour + ":" + Minute + ":" + Second;
        }
        public string AllSeconds()
        {
            int AllSeconds = (Hour * 60 + Minute) * 60 + Second;
            return "Seconds: " + AllSeconds;
        }
    }
    class Lab2
    {
        static void Main()
        {

        }
    }
}
