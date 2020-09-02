/*
 * Andy Le
 * 000805099
 * Implementation of user menu
 * I, Andy Le, 000805099 certify that this material is my original work. No other person's work has been used without due acknowledgement.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.CompilerServices;

namespace Lab_1
{
    class Program
    {
        /// <summary>
        /// Main Method that reads in text file, prompts user to input method of sorting, and displays sorted array of customers
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            FileStream a = new FileStream("../../customers.txt", FileMode.Open, FileAccess.Read);
            StreamReader b = new StreamReader(a);
            int numLines = 0;
            string h = "";
            while ((h = b.ReadLine()) != null)
            {
                numLines += 1;
            }
            a.Close();
            b.Close();
            FileStream f = new FileStream("../../customers.txt", FileMode.Open, FileAccess.Read);
            StreamReader d = new StreamReader(f);
            Customer[] customers = new Customer[numLines];
            string[] t = new string[5];
            string l = "";
            int c = 0;
            int userIn = 0;
            while ((l = d.ReadLine()) != null)
            {
                t = l.Split(',');
                customers[c] = new Customer(t[0], Convert.ToInt32(t[1]), t[2], Convert.ToDecimal(t[3]), Convert.ToInt32(t[4]));
                c += 1;
            }
            d.Close();
            f.Close();
            while (userIn != 6)
            {
                Console.WriteLine("1. Sort by Customer Name");
                Console.WriteLine("2. Soft by Customer Id");
                Console.WriteLine("3. Sort by Product Name");
                Console.WriteLine("4. Sort by Quantity");
                Console.WriteLine("5. Sort by Sales Total\r\n");
                Console.WriteLine("6. Exit\r\n");
                Console.Write("Enter Choice: ");
                userIn = int.Parse(Console.ReadLine());
                int[] options = {1,2,3,4,5};
                if (options.Contains(userIn))
                {  
                    Console.Clear();
                    Console.WriteLine("************************");
                    Console.WriteLine("* Subquery Electronics *");
                    Console.WriteLine("************************");
                    Console.WriteLine("Customer Name         Id        Product Name                       Sales Price  Quantity  Sales Total");
                    Console.WriteLine("====================  =======   ================================   ===========  ========  ===========");
                }
                else if (userIn != 6)
                {
                    Console.WriteLine();
                    Console.WriteLine("*** Invalid Choice - Try Again ***");
                }
                else
                {
                    Environment.Exit(0);
                }
                if (userIn == 1)
                {
                    var sorted = 
                    from i in customers
                    orderby i.GetName()
                    select i;
                    foreach (var j in sorted)
                    {
                        Console.WriteLine(j);
                    }
                }
                else if (userIn == 2)
                {
                    var sorted = 
                    from i in customers
                    orderby i.GetId()
                    select i;
                    foreach (var j in sorted)
                    {
                        Console.WriteLine(j);
                    }
                }
                else if (userIn == 3)
                {
                    var sorted = 
                    from i in customers
                    orderby i.GetProductName()
                    select i;
                    foreach (var j in sorted)
                    {
                        Console.WriteLine(j);
                    }
                }
                else if (userIn == 4)
                {
                    var sorted = 
                    from i in customers
                    orderby i.GetQuantity()
                    select i;
                    foreach (var j in sorted)
                    {
                        Console.WriteLine(j);
                    }
                }
                else if (userIn == 5)
                {
                    var sorted = 
                    from i in customers
                    orderby i.GetSalesTotal()
                    select i;
                    foreach (var j in sorted)
                    {
                        Console.WriteLine(j);
                    }
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
