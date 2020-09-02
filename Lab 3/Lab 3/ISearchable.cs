﻿/*
  Interface: ISearchable.cs
  Author:    Nicholas J. Corkigian
  Date:      October 5, 2017
  Reviewed:  Jamie Forde
  Date:      July 01, 2020

  Purpose: This interface has one method that classes making use of must
           implement. 

           This code is not to be altered.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    /// <summary>
    /// The class implementing the Search() method will be assumed to
    /// use a string search key as a parameter and return a boolean
    /// value to indicate if that key was successfully found.
    /// </summary>
    public interface ISearchable
    {
        bool Search(string key);
    }
}