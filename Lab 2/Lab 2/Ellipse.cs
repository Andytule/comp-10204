/*
 * Andy Le
 * 000805099
 * Implementation of the Ellipse class
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
    /// Implementation of a class called Ellipse which stores the dimensions of the shape
    /// </summary>
    public class Ellipse : TwoDimensionalShape
    {
        private double ma;
        private double mi;

        /// <summary>
        /// Constructor method for ellipse class
        /// </summary>
        /// <param name="ma"></param>Represents the s.major of the ellipse
        /// <param name="mi"></param>Represents the s.minor of the ellipse
        public Ellipse(double ma = 0, double mi = 0) : base()
        {
            base.Type = "Ellipse";
            Major = ma;
            Minor = mi;
        }

        /// <summary>
        /// Get and set methods for major
        /// </summary>
        public double Major
        {
            get
            {
                return this.ma;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                        value, $"{nameof(Major)} must be greater than or equal to 0");
                }
                this.ma = value;
            }
        }

        /// <summary>
        /// Get and set methods for minor
        /// </summary>
        public double Minor
        {
            get
            {
                return this.mi;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                        value, $"{nameof(Minor)} must be greater than or equal to 0");
                }
                this.mi = value;
            }
        }

        /// <summary>
        /// Method to calculate area
        /// </summary>
        /// <returns></returns>
        public override double CalculateArea()
        {
            return Major * Minor * PI;
        }

        /// <summary>
        /// Method to set data
        /// </summary>
        public override void SetData()
        {
            Console.Write("Enter the semi-major axis length: ");
            Major = double.Parse(Console.ReadLine());
            Console.Write("Enter the semi-minor axis length: ");
            Minor = double.Parse(Console.ReadLine());
        }

        /// <summary>
        /// Method for string output
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{base.ToString()}{Major:F} s.major x {Minor:F} s.minor";
        }
    }
}
