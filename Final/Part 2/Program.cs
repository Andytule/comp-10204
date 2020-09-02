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
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using Timer = System.Timers.Timer;

namespace Part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int minutes = 0;
            Queue<PrintJob> printer1 = new Queue<PrintJob>();
            Queue<PrintJob> printer2 = new Queue<PrintJob>();
            Random num = new Random();
            int pagecount1 = 0;
            int pagecount2 = 0;
            while (minutes != 30)
            {
                Thread.Sleep(60000);
                if (num.Next(0, 4) == 3)
                {
                    printer1.Enqueue(new PrintJob(Guid.NewGuid(), num.Next(1, 6)));
                }
                if (num.Next(0, 4) == 3)
                {
                    printer2.Enqueue(new PrintJob(Guid.NewGuid(), num.Next(1, 6)));
                }
                if (printer1.Count != 0)
                {
                    if (pagecount1 == printer1.Peek().Pages)
                    {
                        printer1.Dequeue();
                        pagecount1 = 0;
                    }
                    else
                    {
                        pagecount1 += 1;
                    }
                }
                if (printer2.Count != 0)
                {
                    if (pagecount2 == printer2.Peek().Pages)
                    {
                        printer2.Dequeue();
                        pagecount2 = 0;
                    }
                    else
                    {
                        pagecount2 += 1;
                    }
                }
                
                Console.WriteLine($"At minute {minutes}:");
                minutes += 1;
                if (printer1.Count != 0)
                {
                    Console.WriteLine($"\tPrinter 1: PrintJobs Queued : {printer1.Count()}");
                    Console.WriteLine($"\t\tPrintJob: {printer1.Peek().Id}");
                }
                if (printer2.Count != 0)
                {
                    Console.WriteLine($"\tPrinter 2: PrintJobs Queued : {printer2.Count()}");
                    Console.WriteLine($"\t\tPrintJob: {printer2.Peek().Id}");
                }
            }
            

            Console.ReadKey();
        }
    }
}
