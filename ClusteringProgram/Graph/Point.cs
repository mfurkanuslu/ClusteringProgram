using System;

namespace ClusteringProgram.Graph
{
    public class CPPoint
    {
        public int X { get; }
        public int Y { get; }

        public CPPoint(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override bool Equals(object obj)
        {
            var other = (CPPoint)obj;
            return X == other.X && Y == other.Y;
        }

        public override int GetHashCode()
        {
            var hash = 97 + X.GetHashCode();
            hash = (hash * 17) + Y.GetHashCode();
            return hash;
        }

        public static bool operator ==(CPPoint a, CPPoint b)
        {
            return a.X == b.X && a.Y == b.Y;
        }

        public static bool operator !=(CPPoint a, CPPoint b)
        {
            return a.X != b.X || a.Y != b.Y;
        }

        public static double operator -(CPPoint point1, CPPoint point2)
        {
            return Math.Sqrt(Math.Pow(point1.X - point2.X, 2) + Math.Pow(point1.Y - point2.Y, 2));
        }

        public override string ToString()
        {
            return string.Format("({0}, {1})", X, Y);
        }

    }
}
