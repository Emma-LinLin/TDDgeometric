using System;
using System.Collections.Generic;
using System.Text;

namespace TDDgeometric.Models
{
    public class IsocelesTriangle : GeometricShapes
    {
        public float Side { get; set; }

        public IsocelesTriangle(float side)
        {
            Side = side;
        }

        public override float GetArea()
        {
            if(Side > 0)
            {
                var height = MathF.Sqrt(MathF.Pow(Side, 2) - MathF.Pow(Side/2, 2));
                var result = MathF.Round((Side * height) / 2, 2);
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
                var result = MathF.Round((Side * 3), 2);
                if(result < float.MaxValue)
                {
                    return result;
                }
            }
            return default;
        }
    }
}
