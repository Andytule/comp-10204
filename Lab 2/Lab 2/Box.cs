/*
 * Andy Le
 * 000805099
 * Implementation of the Box class
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
    /// Implementation of Box class which stores the dimensions of the shapef
    /// </summary>
    public class Box : ThreeDimensionalShape
    {
        private double l;
        private double w;
        private double h;

        /// <summary>
        /// Constructor method for box class
        /// </summary>
        /// <param name="l"></param>Represents the length of the box
        /// <param name="w"></param>Represents the width of the box
        /// <param name="h"></param>Represents the height of the box
        public Box(double l = 0, double w = 0, double h = 0) : base ()
        {
            base.Type = "Box";
            Length = l;
            Width = w;
            Height = h;
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
            return 2 * (Length * Width + Length * Height + Width * Height);
        }

        /// <summary>
        /// Method to calculate volume
        /// </summary>
        /// <returns></returns>
        public override double CalculateVolume()
        {
            return Length * Width *Height;
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
            Console.Write("Enter a height: ");
            Height = double.Parse(Console.ReadLine());
        }

        /// <summary>
        /// Method for string output
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{base.ToString()}{Length:F} l x {Width:F} w x {Height:F} h";
        }
    }
}
