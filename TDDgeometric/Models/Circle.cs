using System;
using System.Collections.Generic;
using System.Text;

namespace TDDgeometric.Models
{
    public class Circle : GeometricShapes
    {
        public float Radius { get; set; }

        public Circle(float radius)
        {
            Radius = radius;
        }

        public override float GetArea()
        {
            if (Radius > 0)
            {
                var result = MathF.Round(MathF.PI * MathF.Pow(Radius, 2), 2);
                if (result < float.MaxValue)
                {
                    return result;
                }
            }
            return default;
        }

        public override float GetPerimiter()
        {
            if (Radius > 0)
            {
                var result = MathF.Round((2 * MathF.PI * Radius), 2);
                if(result < float.MaxValue)
                {
                    return result;
                }
            }
            return default;
        }
    }
}
