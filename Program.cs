using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace _75_Helper_Method_Validate_Hour
{
    class Time
    {
        private int hour, minute, second;
        public Time(int h, int m, int s) // 3 parameter constructor named Time/ Overloading valid
        {
            hour = h;
            minute = m;
            second = s;
        }
        public Time() // Default constructor named Time. Overloading Valid
        {
            hour = 0;
            minute = 0;
            second = 0;
        }
        public int Hour // Hour property setting with get, set
        {
            get
            {
                return hour;
            }
            set
            {
                hour = value;
            }
        }
        public int Minute // minute property setting with get, set
        {
            get
            {
                return minute;
            }
            set
            {
                minute = value;
            }
        }
        public int Second // second property setting with get, set
        {
            get
            {
                return minute;
            }
            set
            {
                minute = value;
            }
        }
        public void setTime(int h, int m, int s) // set time method takes already inst. obj. and set values for it
        {
            hour = h;
            minute = m;
            second = s;
        }
        public override string ToString()
        {
            return formatTime();
        }
        private String formatTime() // Helper method to help us format the time 
        {
            String hours, minutes, seconds;
            if (hour < 10)
            {
                hours = "0" + hour.ToString(); // print 0 along with the actual hour "01
            }
            else
            {
                hours = hour + ""; // print hours without a zero if hour>9
            }
            if (minute < 10)
            {
                minutes = "0 " + minute.ToString();
            }
            else
            {
                minutes = minute + "";
            }
            if (second < 10)
            {
                seconds = "0" + second.ToString();
            }
            else
            {
                seconds = second + "";
            }
            return hours + ":" + minutes + ":" + seconds;
        }
        private int validateHour(int hour)
        {
            if (hour >= 0 && hour <= 23)
            {
                return hour;
            }
            else
            {
                return 0;
            }
        }
        public Boolean Equals(Time someTime) // argument is some Time Object
        {
            if (this.hour == someTime.hour && this.minute == someTime.minute
                && this.second == someTime.second)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Time theTime = new Time(10, 0, 0);
            Time sameTime = new Time(10, 0, 0);
            if (theTime == sameTime)
            {
                Console.WriteLine("The times are the  same. ");
            }
            else
            {
                Console.WriteLine("The times are not the same.");
            }
        }
    }
}
