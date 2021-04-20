using System;
using System.Collections.Generic;
using System.Text;
using TDDgeometric.Models;

namespace TDDgeometric.Controllers
{
    public class GeometricCalculator
    {
        public float GetTotalArea(GeometricShapes[] shapes)
        {
            if(shapes != null)
            {
                var result = 0.0f;
                foreach(var shape in shapes)
                {
                    result += shape.GetArea();
                }

                if(result < float.MaxValue)
                {
                    return MathF.Round(result, 2);
                }
            }
            return default;
        }

        public float GetTotalPerimiter(GeometricShapes[] shapes)
        {
            if(shapes != null)
            {
                var result = 0.0f;
                foreach(var shape in shapes)
                {
                    result += shape.GetPerimiter();
                }
                if(result < float.MaxValue)
                {
                    return MathF.Round(result, 2);
                }
            }
            return default;
        }
    }
}
