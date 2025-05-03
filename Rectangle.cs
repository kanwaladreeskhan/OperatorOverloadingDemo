using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloadingDemo
{
    internal class Rectangle
    {
        int length;
        int width;
        public Rectangle()
        {
            this.length = 0;
            this.width = 0;
        }
        public Rectangle(int length,int width)
        {
            this.length = length;
            this.width = width;
        }
        public void Display()
        {
            Console.WriteLine("Length={0}\nWidth={1}", length, width);
        }
        public static Rectangle operator +(Rectangle r1,Rectangle r2)
        {
            Rectangle r3 = new Rectangle();
            r3.length = r1.length + r2.length;
            r3.width = r1.width + r2.width;
            return r3;
        }

    }
}
