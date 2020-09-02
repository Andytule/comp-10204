/*
 * Andy Le
 * 000805099
 * Implementation of methods and classes that store and organize media
 * I, Andy Le, 000805099 certify that this material is my original work. No other person's work has been used without due acknowledgement.
 */
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    class Program
    {

        static void Main(string[] args)
        {
            string i = "";
            var options = new List<string>{"1","2","3","4","5"};
            while (i != "6")
            {
                Console.WriteLine("Andy's Media Collection");
                Console.WriteLine("=======================");
                Console.WriteLine("1. List All Books");
                Console.WriteLine("2. List All Movies");
                Console.WriteLine("3. List All Songs");
                Console.WriteLine("4. List All Media");
                Console.WriteLine("5. Search All Media by Title\n");
                Console.WriteLine("6. Exit Program\n");

                Console.Write("Enter a choice: ");
                i = Console.ReadLine();
                if (options.Contains(i.ToLower()))
                {
                    int choice;
                    int.TryParse(i, out choice);
                    ReadData(choice);
                    Console.Write("\nPress any key to continue . . .");
                    Console.ReadKey();
                } 
                else if (i == "6")
                {
                    Environment.Exit(0);
                } 
                else {
                    Console.WriteLine("\n*** Invalid Choice - Try Again ***\n");
                    Console.Write("Press any key to continue . . .");
                    Console.ReadKey();
                }
                Console.Clear();
            }
            Console.ReadKey();
        }

        static void ReadData(int choice) 
        {
            FileStream a = new FileStream("../../Data.txt", FileMode.Open, FileAccess.Read);
            try 
            {  
                using (StreamReader b = new StreamReader(a))
                {
                    Media[] medias = new Media[100]; 
                    string line;
                    int c = 0;
                    while ((line = b.ReadLine()) != null)
                    {
                        int typePos = line.IndexOf("|");       
                        string type = line.Substring(0, typePos);
                        if (type == "BOOK")
                        {   
                            int titlePos = line.IndexOf("|", typePos + 1);
                            int yearPos = line.IndexOf("|", titlePos + 1);
                            string title = line.Substring(typePos + 1, titlePos - typePos - 1);
                            string year = line.Substring(titlePos + 1, yearPos - titlePos - 1);
                            int yearInt;
                            int.TryParse(year, out yearInt);
                            string author = line.Substring(yearPos + 1);
                            string summary = "";
                            string temp;
                            while ((temp = b.ReadLine()) != "-----")
                            {
                                summary = summary + temp;
                            }
                            Book me = new Book(author, summary, title, yearInt);
                            medias[c] = me;
                        }
                        else if (type == "MOVIE") 
                        {
                            int titlePos = line.IndexOf("|", typePos + 1);
                            int yearPos = line.IndexOf("|", titlePos + 1);
                            string title = line.Substring(typePos + 1, titlePos - typePos - 1);
                            string year = line.Substring(titlePos + 1, yearPos - titlePos - 1);
                            int yearInt;
                            int.TryParse(year, out yearInt);
                            string director = line.Substring(yearPos + 1);
                            string summary = "";
                            string temp;
                            while ((temp = b.ReadLine()) != "-----")
                            {
                                summary = summary + temp;
                            }
                            Movie me = new Movie(director, summary, title, yearInt);
                            medias[c] = me;
                        } 
                        else 
                        {
                            int titlePos = line.IndexOf("|", typePos + 1);
                            int yearPos = line.IndexOf("|", titlePos + 1);
                            int albumPos = line.IndexOf("|", yearPos + 1);
                            string title = line.Substring(typePos + 1, titlePos - typePos - 1);
                            string year = line.Substring(titlePos + 1, yearPos - titlePos - 1);
                            int yearInt;
                            int.TryParse(year, out yearInt);
                            string album = line.Substring(yearPos + 1, albumPos - yearPos - 1);
                            string artist = line.Substring(albumPos + 1);
                            Song me = new Song(album, artist, title, yearInt);
                            medias[c] = me;
                            string skip = b.ReadLine();
                        }
                        c += 1;
                    }
                    Media[] myMedia = new Media[c];
                    for (int i = 0; i < c; i++) 
                    {
                        myMedia[i] = medias[i];
                    }
                    if (choice == 1)
                    {
                        foreach (var i in myMedia)
                        {
                            if (i is Book)
                            {
                                Console.WriteLine(i.toString());
                            }
                        }
                    }
                    else if (choice == 2)
                    {
                        foreach (var i in myMedia)
                        {
                            if (i is Movie)
                            {
                                Console.WriteLine(i.toString());
                            }
                        }
                    }
                    else if (choice == 3)
                    {
                        foreach (var i in myMedia)
                        {
                            if (i is Song)
                            {
                                Console.WriteLine(i.toString());
                            }
                        }
                    }
                    else if (choice == 4)
                    {
                        foreach (var i in myMedia)
                        {
                            Console.WriteLine(i.toString());
                        }
                    }
                    else 
                    {
                        string search;
                        Console.Write("Enter a search string: ");
                        search = Console.ReadLine();
                        for (int i = 0; i < c; i++)
                        {
                            if (myMedia[i].Search(search))
                            {
                                Console.WriteLine(myMedia[i].toString2());
                            }
                        }
                    }
                    b.Close();
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("\ne.ToString: \n" + e);
                Console.WriteLine("\ne.Message: \n" + e.Message);
                Console.WriteLine("\ne.StackTrace: \n" + e.StackTrace);
                Console.WriteLine("\ne.InnerException: \n" + e.InnerException);
            }
            a.Close();
        }
    }
}
