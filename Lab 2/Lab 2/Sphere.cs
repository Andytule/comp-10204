/*
 * Andy Le
 * 000805099
 * Implementation of the Sphere class
 * I, Andy Le, 000805099 certify that this material is my original work. No other person's work has been used without due acknowledgement.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    /// <summary>
    /// Implementation of class called Shphere which stores the dimensions of the shape
    /// </summary>
    public class Sphere : ThreeDimensionalShape
    {
        private double r;

        /// <summary>
        /// Constructor method for sphere class
        /// </summary>
        /// <param name="r"></param>Represents the radius of the sphere
        public Sphere(double r = 0) : base()
        {
            base.Type = "Sphere";
            Radius = r;
        }

        /// <summary>
        /// Get and set methods for radius
        /// </summary>
        public double Radius
        {
            get
            {
                return this.r;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                        value, $"{nameof(Radius)} must be greater than or equal to 0");
                }
                this.r = value;
            }
        }

        /// <summary>
        /// Method to calculate area
        /// </summary>
        /// <returns></returns>
        public override double CalculateArea()
        {
            return 4 * PI * Math.Pow(Radius, 2);
        }

        /// <summary>
        /// Method to calculate volume
        /// </summary>
        /// <returns></returns>
        public override double CalculateVolume()
        {
            return 4 * PI * Math.Pow(Radius, 3) / 3;
        }

        /// <summary>
        /// Method to set data
        /// </summary>
        public override void SetData()
        {
            Console.Write("Enter a radius: ");
            Radius = double.Parse(Console.ReadLine());
        }

        /// <summary>
        /// Method for string output
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{base.ToString()}{Radius:F} r";
        }
    }
}
