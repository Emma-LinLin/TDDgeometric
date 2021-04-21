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
            if(Side > 0)
            {
                var result = MathF.Round(MathF.Pow(Side, 2), 2);
                if(result < float.MaxValue)
                {
                    return result;
                }
            }
            return default;
        }

        public override float GetPerimiter()
        {
            if(Side > 0)
            {
                var result = Side * 4;
                if(result < float.MaxValue)
                {
                    return result;
                }
            }
            return default;
        }
    }
}
