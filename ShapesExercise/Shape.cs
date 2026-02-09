using System;
using System.Collections.Generic;

namespace ShapesExample
{
    public abstract class Shape : IComparable<Shape>
    {
        public string Color { get; set; }

        protected Shape(string color)
        {
            Color = color;
        }

        public abstract double GetArea();
        public abstract void GetInfo();

        public int CompareTo(Shape? other)
        {
            if (other == null) return 1;

            return GetArea().CompareTo(other.GetArea());
        }
    }
}
