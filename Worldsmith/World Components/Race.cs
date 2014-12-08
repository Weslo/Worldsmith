#region File Description
/*
 * Race.cs
 * This class describes a Race in a World.
 * 
 * Wes Rockholz
 * Copyright 2014 Wes Rockholz
 */
#endregion File Description

#region Using Statements
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion Using Statements

namespace Worldsmith
{
    public class Race
    {
        public string Name { get; set; }
        public string Description { get; set; }

        /// <summary>
        /// Base constructor.
        /// </summary>
        /// <param name="name">Name of the race.</param>
        public Race(string name)
        {
            Name = name;
        }
    }
}
