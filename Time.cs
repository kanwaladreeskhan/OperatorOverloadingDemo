using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloadingDemo
{
    internal class Time
    {
        int hour;
        int minute;
        int second;
        public Time()
        {
            this.hour = 0;
            this.minute = 0;
            this.second = 0;

        }
        public Time(int hour, int minute, int second)
        {
            this.hour = hour;
            this.minute = minute;
            this.second = second;
        }
        public void Display()
        {
            Console.WriteLine("Time={0}:{1}:{2}", hour, minute, second);
        }
        public static Time operator +(Time t1, Time t2)
        {
            Time t = new Time();
            t.hour = t1.hour + t2.hour;
            t.minute = t1.minute + t2.minute;
            t.second = t1.second + t2.second;
            if (t.second >= 60)
            {
                t.second -= 60;
                t.minute++;
            }
            if (t.minute >= 60)
            {
                t.minute -= 60;
                t.hour++;
            }
            return t;
        }
        public static bool operator <(Time t1, Time t2)
        {
            if (t1.hour < t2.hour) return true;
            if (t1.hour > t2.hour) return false;
            if (t1.minute < t2.minute) return true;
            if (t1.minute > t2.minute) return false;
            return t1.second < t2.second;
        }
    
        public static bool operator >(Time t1, Time t2)
        {
            return t1 > t2;
        }
    }
}
