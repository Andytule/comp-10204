/*
 * Andy Le
 * 000805099
 * Implementation Tag Class
 * I, Andy Le, 000805099 certify that this material is my original work. No other person's work has been used without due acknowledgement.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    /// <summary>
    /// Class for html tag
    /// </summary>
    public class Tag 
    {
        public string Text { get; set; }
        public string Type { get; set; }

        public override string ToString()
        {
            return $"Tag: {Type} {Text}";
        }


    }
}
