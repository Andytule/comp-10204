/*
 * Andy Le
 * 000805099
 * Part 2
 * I, Andy Le, 000805099 certify that this material is my original work. No other person's work has been used without due acknowledgement.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_2
{
    public class PrintJob
    {
        public Guid Id { get; set; }
        public int Pages { get; set; }

        public PrintJob(Guid id, int pages)
        {
            Id = id;
            Pages = pages;
        }

        public override string ToString() => $"ID: {Id} \nPages: {Pages}";
    }
}
