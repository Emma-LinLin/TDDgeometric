using System;
using System.Collections.Generic;
using System.Text;

namespace TDDgeometric.Models
{
    public class Rectangle : GeometricShapes
    {
        public float Base { get; set; }
        public float Height { get; set; }

        public Rectangle(float Rbase, float height)
        {
            Base = Rbase;
            Height = height;
        }

        public override float GetArea()
        {
            if(Base < float.MaxValue / Height)
            {
                return Base >= 0 && Height >= 0 ? Base * Height : default;
            }
            return default;
        }

        public override float GetPerimiter()
        {
            if(Base < float.MaxValue/2 && Height < float.MaxValue / 2)
            {
                return Base >= 0 && Height >= 0 ? (Base * 2) + (Height * 2) : default;
            }
            return default;
        }
    }
}
