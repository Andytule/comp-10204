﻿/*
 * Andy Le
 * 000805099
 * Implementation of Movie class
 * I, Andy Le, 000805099 certify that this material is my original work. No other person's work has been used without due acknowledgement.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{   
    /// <summary>
    /// Implementation of a class called Movie which inherits from Media and implements IEncryptable
    /// </summary>
    public class Movie : Media, IEncryptable
    {
        public string Director { get; set; }
        public string Summary { get; set; }

        /// <summary>
        /// Constructor method for movie class
        /// </summary>
        public Movie(string director, string summary, string title, int year) : base(title, year)
        {
            Director = director;
            Summary = summary;
        }

        /// <summary>
        /// Method to encrypt summary
        /// </summary>
        public string Encrypt()
        {
            char[] letters = Summary.ToCharArray();
            for (int i = 0; i < letters.Length; i++)
            {
                int num = (int)letters[i];
                if ((97 <= num) && (num <= 122))
                {
                    if (num < 109)
                    {
                        num += 13;
                    }
                    else
                    {
                        num -= 13;
                    }
                } 
                else if ((65 <= num) && (num <= 90)) 
                {
                    if (num < 77)
                    {
                        num += 13;
                    }
                    else
                    {
                        num -= 13;
                    }
                }
                letters[i] = (char)num;
            }
            return new string(letters);
        }

        /// <summary>
        /// Method to decrypt summary
        /// </summary>
        public string Decrypt()
        {
            char[] letters = Summary.ToCharArray();
            for (int i = 0; i < letters.Length; i++)
            {
                int num = (int)letters[i];
                if ((97 <= num) && (num <= 122))
                {
                    if (num < 109)
                    {
                        num += 13;
                    }
                    else
                    {
                        num -= 13;
                    }
                } 
                else if ((65 <= num) && (num <= 90)) 
                {
                    if (num < 77)
                    {
                        num += 13;
                    }
                    else
                    {
                        num -= 13;
                    }
                }
                letters[i] = (char)num;
            }
            return new string(letters);
        }

        /// <summary>
        /// Method for string output excluding summary
        /// </summary>
        public override string toString() => $"Movie Title: {base.Title} ({base.Year})\nDirector: {Director}\n--------------------";
        /// <summary>
        /// Method for string output including summary
        /// </summary>
        public override string toString2() => $"Movie Title: {base.Title} ({base.Year})\nDirector: {Director}\n\n{Decrypt()}\n--------------------";
    }
}
