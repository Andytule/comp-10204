/*
 * Andy Le
 * 000805099
 * Implementation of the ThreeDimensionalShape class
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
    /// Implementation of ThreeDimensionalShape class which stores the dimensions of a three dimensional shape
    /// </summary>
    public abstract class ThreeDimensionalShape : Shape
    {
        /// <summary>
        /// Constructor method of the threedimensionalshape class
        /// </summary>
        public ThreeDimensionalShape() : base()
        {
            
        } 

        /// <summary>
        /// Method to calculate area
        /// </summary>
        /// <returns></returns>
        public abstract override double CalculateArea();

        /// <summary>
        /// Method to calculate volume
        /// </summary>
        /// <returns></returns>
        public abstract override double CalculateVolume();

        /// <summary>
        /// Method to set data
        /// </summary>
        public abstract override void SetData();

        /// <summary>
        /// Method for string output
        /// </summary>
        /// <returns></returns>
        public override string ToString() => $"{base.Type, -20}{CalculateArea(), 10:F}     {CalculateVolume(), -15:F}";  
    }
}
