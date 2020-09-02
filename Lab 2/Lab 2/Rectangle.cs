/*
 * Andy Le
 * 000805099
 * Implementation of the Rectangle class
 * I, Andy Le, 000805099 certify that this material is my original work. No other person's work has been used without due acknowledgement.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    /// <summary>
    /// Implementation of class called Rectangle which stores the dimension of the shape
    /// </summary>
    public class Rectangle : TwoDimensionalShape
    {
        private double l;
        private double w;

        /// <summary>
        /// Constructor method for rectangle class
        /// </summary>
        /// <param name="l"></param>Represents the length of the rectangle
        /// <param name="w"></param>Represents the width of the rectangle
        public Rectangle(double l = 0, double w = 0) : base()
        {
            base.Type = "Rectangle";
            Length = l;
            Width = w;
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
        /// Get and set methods for width
        /// </summary>
        public double Width
        {
            get
            {
                return this.w;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                        value, $"{nameof(Width)} must be greater than or equal to 0");
                }
                this.w = value;
            }
        }

        /// <summary>
        /// Method to calculate area
        /// </summary>
        /// <returns></returns>
        public override double CalculateArea()
        {
            return Length * Width;
        }

        /// <summary>
        /// Method to set data
        /// </summary>
        public override void SetData()
        {
            Console.Write("Enter a length: ");
            Length = double.Parse(Console.ReadLine());
            Console.Write("Enter a width: ");
            Width = double.Parse(Console.ReadLine());
        }

        /// <summary>
        /// Method for string output
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{base.ToString()}{Length:F} l x {Width:F} w";
        }
    }
}
