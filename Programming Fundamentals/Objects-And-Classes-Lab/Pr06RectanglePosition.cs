using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr06RectanglePosition
{
    class Pr06RectanglePosition
    {
        static void Main(string[] args)
        {
            Rectangle r1 = ReadRectangle();
            Rectangle r2 = ReadRectangle();
            Console.WriteLine(r1.isInside(r2) ? "Inside" : "Not inside");
        }

        private static Rectangle ReadRectangle()
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Rectangle rectangle = new Rectangle();
            rectangle.Left = input[0];
            rectangle.Top = input[1];
            rectangle.Width = input[2];
            rectangle.Height = input[3];
            return rectangle;
        }
    }
    class Rectangle
    {
        public int Top { get; set; }
        public int Left { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public int CalcArea()
        {
            return Width * Height;
        }

        public int Bottom
        {
            get
            {
                return Top + Height;
            }
        }

        public int Right
        {
            get
            {
                return Left + Width;
            }
        }

        public bool isInside(Rectangle r)
        {
            return (r.Left <= Left) && (r.Right >= Right) && (r.Top <= Top) && (r.Bottom >= Bottom);
        }
    }
}
