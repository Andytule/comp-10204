using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var shapes = new List<Shape>();
            var choices = new List<string>{"A", "B", "C", "D", "E", "F", "G", "H", "I", "J"};
            string i = "Z";
            while (i != "0")
            {
                Console.Clear();
                Console.WriteLine("Andy's Geometry Class:");
                Console.WriteLine("A - Rectangle       E - Ellipse         I - Triangle");
                Console.WriteLine("B - Square          F - Circle          J - Tetrahedron");
                Console.WriteLine("C - Box             G - Cylinder");
                Console.WriteLine("D - Cube            H - Sphere");
                Console.WriteLine("\n0 - List all shapes and Exit...\n");
                Console.WriteLine($"{Shape.GetCount()} shapes entered so far\n");
                Console.Write("Enter your choice: ");
                i = Console.ReadLine();
                if (choices.Contains(i.ToUpper()))
                {
                    Console.WriteLine("\n");
                    if (i.ToUpper() == "A")
                    {
                        Rectangle temp = new Rectangle();
                        temp.SetData();
                        shapes.Add(temp);
                    }
                    else if (i.ToUpper() == "B")
                    {
                        Square temp = new Square();
                        temp.SetData();
                        shapes.Add(temp);
                    }
                    else if (i.ToUpper() == "C")
                    {
                        Box temp = new Box();
                        temp.SetData();
                        shapes.Add(temp);
                    }
                    else if (i.ToUpper() == "D")
                    {
                        Cube temp = new Cube();
                        temp.SetData();
                        shapes.Add(temp);
                    }
                    else if (i.ToUpper() == "E")
                    {
                        Ellipse temp = new Ellipse();
                        temp.SetData();
                        shapes.Add(temp);
                    }
                    else if (i.ToUpper() == "F")
                    {
                        Circle temp = new Circle();
                        temp.SetData();
                        shapes.Add(temp);
                    }
                    else if (i.ToUpper() == "G")
                    {
                        Cylinder temp = new Cylinder();
                        temp.SetData();
                        shapes.Add(temp);
                    }
                    else if (i.ToUpper() == "H")
                    {
                        Sphere temp = new Sphere();
                        temp.SetData();
                        shapes.Add(temp);
                    }
                    else if (i.ToUpper() == "I")
                    {
                        Triangle temp = new Triangle();
                        temp.SetData();
                        shapes.Add(temp);
                    }
                    else
                    {
                        Tetrahedron temp = new Tetrahedron();
                        temp.SetData();
                        shapes.Add(temp);
                    }
                }
                else if (i != "0")
                {
                    Console.WriteLine("\nThis is not a valid choice, please try again");
                    Console.WriteLine("Press any key to continue . . .");
                    Console.ReadKey();
                }
            }
            Console.Clear();
            Console.WriteLine("Andy's Geometry Class:\n");
            Console.WriteLine($"There are {Shape.GetCount()} objects\n");
            Console.WriteLine("Shape               Area           Volumne        Details");
            Console.WriteLine("===============     ==========     ==========     ============================== ");
            foreach (var j in shapes)
            {
                Console.WriteLine($"{j.ToString()}");
            }

            Console.ReadKey();
        }
    }
}
