using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloadingDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Operator Overloading for Time\n==============");
            Console.WriteLine("Time 1\n--------------");
            Console.WriteLine("Enter the hours of Time 1:");
            int h1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the minutes of Time 1:");
            int m1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the seconds of Time 1:");
            int s1 = Convert.ToInt32(Console.ReadLine());
            Time t1 = new Time(h1, m1, s1);
            t1.Display();
            Console.WriteLine("Time 2\n--------------");
            Console.WriteLine("Enter the hours of Time 2:");
            int h2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the minutes of Time 2:");
            int m2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the seconds of Time 2:");
            int s2 = Convert.ToInt32(Console.ReadLine());
            Time t2 = new Time(h2, m2, s2);
            t2.Display();
            Console.WriteLine("Addition of two Time Objects:\n--------------");
            Time t = t1 + t2;
            t.Display();
            Console.WriteLine("Comparision\n--------------");
            if (t1 < t2)
            {
                Console.WriteLine("Time 1 is less than Time 2");
            }
            else
            {
                Console.WriteLine("Time 1 is greater than Time 2");
            }
            Console.WriteLine("Operator Overloading for Rectangle\n==============");
            Console.WriteLine("Rectangle 1\n--------------");
            Console.WriteLine("Enter the length of 1st rectangle:");
            int l1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the width of 1st rectangle:");
            int w1 = Convert.ToInt32(Console.ReadLine());
            Rectangle r1 = new Rectangle(l1, w1);
            r1.Display();
            Console.WriteLine("Rectangle 2\n-------------");
            Console.WriteLine("Enter the length of 2nd rectangle:");
            int l2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the width of 2nd rectangle:");
            int w2 = Convert.ToInt32(Console.ReadLine());
            Rectangle r2 = new Rectangle(l2, w2);
            r2.Display();
            Console.WriteLine("Addition of Rectangle Objects\n--------------");
            Rectangle r3 = r1 + r2;
            r3.Display();
        }
    }
}
