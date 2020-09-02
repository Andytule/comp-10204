/*
 * Andy Le
 * 000805099
 * Implementation of the Cylinder class
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
    /// Implementation of a class called Cylinder which stores the dimension of the shape
    /// </summary>
    public class Cylinder : ThreeDimensionalShape
    {
        private double r;
        private double h;

        /// <summary>
        /// Constructor method for cylinder class
        /// </summary>
        /// <param name="r"></param>Represents the radius of the cylinder
        /// <param name="h"></param>Represents the height of the cylinder
        public Cylinder(double r = 0, double h = 0) : base()
        {
            base.Type = "Cylinder";
            Radius = r;
            Height = h;
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
            return 2 * PI * Radius * Height + 2 * PI * Math.Pow(Radius, 2);
        }

        /// <summary>
        /// Method to calculate volume
        /// </summary>
        /// <returns></returns>
        public override double CalculateVolume()
        {
            return PI * Math.Pow(Radius, 2) * Height;
        }

        /// <summary>
        /// Method to set data
        /// </summary>
        public override void SetData()
        {
            Console.Write("Enter a radius: ");
            Radius = double.Parse(Console.ReadLine());
            Console.Write("Enter a height: ");
            Height = double.Parse(Console.ReadLine());
        }

        /// <summary>
        /// Method for string output
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{base.ToString()}{Radius:F} r x {Height:F} h";
        }
    }
}
