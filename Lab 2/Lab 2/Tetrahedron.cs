/*
 * Andy Le
 * 000805099
 * Implementation of the Tetrahedron class
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
    /// Implementation of a class called tetrahedron which stores the dimensions of the shape
    /// </summary>
    public class Tetrahedron : ThreeDimensionalShape
    {
        private double l;

        /// <summary>
        /// Constructor method for tetrahedron class
        /// </summary>
        /// <param name="l"></param>Represents the length of the tetrahedron
        public Tetrahedron(double l = 0) : base()
        {
            base.Type = "Tetrahedron";
            Length = l;
        }

        /// <summary>
        /// Get and set methods for length
        /// </summary>
        public double Length
        {
            get
            {
                return this.l;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                        value, $"{nameof(Length)} must be greater than or equal to 0");
                }
                this.l = value;
            }
        }

        /// <summary>
        /// Method to calculate area
        /// </summary>
        /// <returns></returns>
        public override double CalculateArea()
        {
            return Math.Sqrt(3) * Math.Pow(Length, 2);
        }

        /// <summary>
        /// Method to calculate volume
        /// </summary>
        /// <returns></returns>
        public override double CalculateVolume()
        {
            return Math.Pow(Length, 3) / (6 * Math.Sqrt(2));
        }

        /// <summary>
        /// Method to set data
        /// </summary>
        public override void SetData()
        {
            Console.Write("Enter a length: ");
            Length = double.Parse(Console.ReadLine());
        }

        /// <summary>
        /// Method for string output
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{base.ToString()}{Length:F} l";
        }
    }
}
