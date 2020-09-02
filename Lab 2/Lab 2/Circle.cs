/*
 * Andy Le
 * 000805099
 * Implementation of the Circle class
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
    /// Implementation of the Circle class which stores the dimensions of the shape
    /// </summary>
    public class Circle : TwoDimensionalShape
    {
        private double r;

        /// <summary>
        /// Constructor method for the circle class
        /// </summary>
        /// <param name="r"></param>Represents the radius of the circle
        public Circle(double r = 0) : base()
        {
            base.Type = "Circle";
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
            return PI * Math.Pow(Radius, 2);
        }

        /// <summary>
        /// Nethod to set data
        /// </summary>
        public override void SetData()
        {
            Console.Write("Enter the radius: ");
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
