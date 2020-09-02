/*
 * Andy Le
 * 000805099
 * Implementation of the Square class
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
    /// Implementation of a class called square which stores the dimension of the shape
    /// </summary>
    public class Square : TwoDimensionalShape
    {
        private double l;

        /// <summary>
        /// Constructor method for square class
        /// </summary>
        /// <param name="l"></param>Represents the length of the square
        public Square(double l = 0) : base()
        {
            base.Type = "Square";
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
        /// Method to calcualte area
        /// </summary>
        /// <returns></returns>
        public override double CalculateArea()
        {
            return Math.Pow(Length, 2);
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
