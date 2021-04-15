using System;
using System.Collections.Generic;
using System.Text;

namespace TDDgeometric.Models
{
    public class Square : GeometricShapes
    {
        public float Side { get; set; }

        public Square(float side)
        {
            Side = side;
        }

        public override float GetArea()
        {
            if (Side < MathF.Sqrt(float.MaxValue))
            {
                return Side > 0 ? MathF.Round(MathF.Pow(Side, 2), 2) : default;
            }
            return default;
        }

        public override float GetPerimiter()
        {
            if(Side < float.MaxValue / 4)
            {
                return Side > 0 ? Side * 4 : default;
            }
            return default;
        }
    }
}
