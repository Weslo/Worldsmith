#region File Description
/*
 * Faction.cs
 * This class describes a Faction in a World.
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
    public class Faction
    {
        public string Name { get; set; }
        public string Description { get; set; }

        /// <summary>
        /// Base constructor.
        /// </summary>
        /// <param name="name">Name of the Faction.</param>
        public Faction (string name)
        {
            Name = name;
        }
    }
}
