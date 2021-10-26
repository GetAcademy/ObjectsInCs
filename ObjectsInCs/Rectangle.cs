using System;

namespace ObjectsInCs
{
    class Rectangle
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public int Width { get; private set; }
        public int Height { get; private set; }

        public int Area => Height * Width;

        public Rectangle(int x, int y, int width, int height)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
        }

        public int CalculateArea()
        {
            return Height * Width;
        }

        public int CalculateCircumference()
        {
            return Height * 2 + Width * 2;
        }

        public int GetX()
        {
            return X;
        }

        public void SetX(int x)
        {
            X = x;
        }

        //internal int XX
        //{
        //     get
        //    {
        //        return X;
        //    }
        //     set
        //    {
        //        X = value;
        //    }
        //}

    }
}
