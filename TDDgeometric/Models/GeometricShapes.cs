namespace TDDgeometric.Models
{
    public abstract class GeometricShapes
    {
        public float Area { get; set; }
        public float Perimeter { get; set; }

        /// <summary>
        /// Get the area of an object
        /// </summary>
        /// <returns>area</returns>
        public virtual float GetArea()
        {
            return default;
        }

        /// <summary>
        /// Get the perimiter of an object
        /// </summary>
        /// <returns>perimiter</returns>
        public virtual float GetPerimiter()
        {
            return default;
        }
    }
}
