/*
 * Andy Le
 * 000805099
 * Implementation of the Triangle class
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
    /// Implementation of a class called triangle which stores the dimensions of the shape
    /// </summary>
    public class Triangle : TwoDimensionalShape
    {
        private double b;
        private double h;

        /// <summary>
        /// Constructor method for Triangle class
        /// </summary>
        /// <param name="b"></param>Represents the base of the triangle
        /// <param name="h"></param>Represents the height of the triangle
        public Triangle(double b = 0, double h = 0) : base()
        {
            base.Type = "Triangle";
            Base = b;
            Height = h;

        }

        /// <summary>
        /// Get and set methods for base
        /// </summary>
        public double Base
        {
            get
            {
                return this.b;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                        value, $"{nameof(Base)} must be greater than or equal to 0");
                }
                this.b = value;
            }
        }

        /// <summary>
        /// Get and set methods for height
        /// </summary>
        public double Height
        {
            get
            {
                return this.h;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                        value, $"{nameof(Height)} must be greater than or equal to 0");
                }
                this.h = value;
            }
        }

        /// <summary>
        /// Method to calculate area
        /// </summary>
        /// <returns></returns>
        public override double CalculateArea()
        {
            return Base * Height / 2;
        }

        /// <summary>
        /// Method to set data
        /// </summary>
        public override void SetData()
        {
            Console.Write("Enter the base: ");
            Base = double.Parse(Console.ReadLine());
            Console.Write("Enter the height: ");
            Height = double.Parse(Console.ReadLine());
        }

        /// <summary>
        /// Method for string output
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{base.ToString()}{Base:F} b x {Height:F} h";
        }
    }
}
